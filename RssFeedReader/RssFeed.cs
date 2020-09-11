using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RssFeedReader
{
    public class RssFeed
    {
        private RssFeed() { }

        public List<ChannelItem> Items { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

        public static RssFeed CreateRssFeed(string url)
        {
            var result = new RssFeed { Items = new List<ChannelItem>() };
            using (var stream = GetRssFeedStream(url))
            {
                var root = XElement.Load(stream);

                var channel = root.Element("channel");
                result.Title = channel?.Element("title")?.Value;
                result.Link = channel?.Element("link")?.Value;
                result.Description = channel?.Element("description")?.Value;
                result.Language = channel?.Element("language")?.Value;

                var items = channel?.Elements("item");
                foreach (var item in items)
                {
                    var channelItem = new ChannelItem()
                    {
                        Title = item.Element("title")?.Value,
                        Description = item.Element("description")?.Value,
                        Link = item.Element("link")?.Value
                    };
                    result.Items.Add(channelItem);
                }
            }

            return result;
        }

        private static Stream GetRssFeedStream(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var client = new WebClient();
            var stream = client.OpenRead(url);
            return stream;
        }

        private string GetFeedDisplayName(string title, string description)
        {
            return $"RSS : {title} ({description})";
        }

        public override string ToString()
        {
            return GetFeedDisplayName(Title, Description);
        }
    }

    public class ChannelItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
