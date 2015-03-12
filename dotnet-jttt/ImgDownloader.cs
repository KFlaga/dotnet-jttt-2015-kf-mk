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
    class ImgDownloader
    {
        string url;
        string htmlSource;

        public ImgDownloader(string url)
        {
            this.url = url;
        }

        private string GetPageHtml()
        {
            using (WebClient wc = new WebClient())
            {
                byte[] data = wc.DownloadData(url);
                string html = System.Net.WebUtility.HtmlDecode(Encoding.UTF8.GetString(data));

                return html;
            }
        }

        public Image DownloadIfKeyIsInTitle(string key)
        {
            htmlSource = GetPageHtml();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlSource);

            var nodes = doc.DocumentNode.Descendants("img");
            var cond = new ConditionContainSubstring();

            foreach (var node in nodes)
            {
                cond.SetParams(key, (node.GetAttributeValue("alt", "")));
                if (cond.Check())
                {
                    return DownloadImage(url + node.GetAttributeValue("src", ""));
                }
            }

            return null;
        }

        private Image DownloadImage(string src)
        {
            byte[] imageData;
            using (WebClient wc = new WebClient())
            {
                imageData = wc.DownloadData(src);
            }

            MemoryStream ms = new MemoryStream(imageData);
            Image image = Image.FromStream(ms);

            return image;
        }

    }
}
