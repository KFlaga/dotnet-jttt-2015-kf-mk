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

        public DownloadImageIfTitleContainsKey()
        {
            
        }

        private string GetPageHtml(string url)
        {
            using (WebClient wc = new WebClient())
            {
                byte[] data = wc.DownloadData(url);
                string html = System.Net.WebUtility.HtmlDecode(Encoding.UTF8.GetString(data));

                return html;
            }
        }

        public void CheckCondition(string key, string url)
        {
            htmlSource = GetPageHtml(url);

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlSource);

            var nodes = doc.DocumentNode.Descendants("img");
            var cond = new ConditionContainSubstring();

            foreach (var node in nodes)
            {
                cond.SetParams(key, (node.GetAttributeValue("alt", "")));
                if (cond.Check())
                {
                    DownloadImage((string)url + node.GetAttributeValue("src", ""));
                    return;
                }
            }
        }

        private void DownloadImage(string src)
        {
            byte[] imageData;
            using (WebClient wc = new WebClient())
            {
                imageData = wc.DownloadData(src);
            }

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
