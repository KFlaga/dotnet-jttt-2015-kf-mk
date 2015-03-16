using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Drawing;

namespace dotnet_jttt
{
    class DownloadImageIfTitleContainsKey : IConditionWithResult
    {
        string htmlSource;
        Image image;
        string url;
        string key;

        public DownloadImageIfTitleContainsKey()
        {
            
        }

        private string GetPageHtml(string url)
        {
            // Pobiera źródło strony
            using (WebClient wc = new WebClient())
            {
                byte[] data = wc.DownloadData(url);
                string html = System.Net.WebUtility.HtmlDecode(Encoding.UTF8.GetString(data));

                return html;
            }
        }

        public void CheckCondition(string[] args)
        {
            key = args[1];
            url = args[0];
            htmlSource = GetPageHtml(url);

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlSource);

            var nodes = doc.DocumentNode.Descendants("img"); // W nodes mamy wszystkie węzły 'img' opisujące obrazki
            var cond = new ConditionContainSubstring();

            foreach (var node in nodes)
            {
                cond.SetParams(key, (node.GetAttributeValue("alt", "")));
                if (cond.Check()) // Sprawdzenie czy opis obrazka zawiera klucz
                {
                    DownloadImage((string)url + node.GetAttributeValue("src", ""));
                    return;
                }
            }
        }

        private void DownloadImage(string src)
        {
            Logger.Instance.AddLog("Ściąganie obrazka");
            // Do image data ściągamy tablicę bitów, które powinny być obrazkiem
            // z podanego źródła
            byte[] imageData;
            using (WebClient wc = new WebClient())
            {
                imageData = wc.DownloadData(src);
            }

            // Aby przerobić tablicę bitów na obrazek stosujemy MemoryStream
            MemoryStream ms = new MemoryStream(imageData);
            Image image = Image.FromStream(ms);

            this.image = image;
        }

        public object GetResult()
        {
            return image;
        }
    }
}
