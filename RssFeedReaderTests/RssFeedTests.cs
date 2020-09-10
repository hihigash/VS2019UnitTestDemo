using Microsoft.VisualStudio.TestTools.UnitTesting;
using RssFeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssFeedReader.Tests
{
    [TestClass()]
    public class RssFeedTests
    {
        [TestCategory("Performance Tests")]
        [Priority(2)]
        [Owner("Takahiro Harada")]
        [Timeout(1000)]
        [TestMethod()]
        public void Constructor_CreateYahooJapanTopTopicsNews()
        {
            var rssFeed = RssFeed.CreateRssFeed("https://news.yahoo.co.jp/rss/topics/top-picks.xml");
            Assert.IsNotNull(rssFeed);
        }

        [TestCategory("Performance Tests")]
        [Priority(2)]
        [Owner("Takahiro Harada")]
        [Timeout(1000)]
        [TestMethod()]
        public void Constructor_CreateYahooJapanDomesticNews()
        {
            var rssFeed = RssFeed.CreateRssFeed("https://news.yahoo.co.jp/rss/categories/domestic.xml");
            Assert.IsNotNull(rssFeed);
        }

        [TestCategory("Performance Tests")]
        [Priority(3)]
        [Owner("Takahiro Harada")]
        [Timeout(1000)]
        [TestMethod()]
        public void Constructor_CreateBingMicrosoftNews()
        {
            var rssFeed = RssFeed.CreateRssFeed("https://www.bing.com/news?q=Microsoft&format=RSS&mkt=ja-JP");
            Assert.IsNotNull(rssFeed);
        }

        [TestCategory("Performance Tests")]
        [Priority(3)]
        [Owner("Takahiro Harada")]
        [Timeout(1000)]
        [TestMethod()]
        public void Constructor_CreateMicrosoftOfficialBlog()
        {
            var rssFeed = RssFeed.CreateRssFeed("https://blogs.microsoft.com/feed/");
            Assert.IsNotNull(rssFeed);
        }
    }
}
