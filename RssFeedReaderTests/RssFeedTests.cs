using Microsoft.VisualStudio.TestTools.UnitTesting;
using RssFeedReader;
using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine(rssFeed);
        }

        [TestCategory("Performance Tests")]
        [Priority(3)]
        [Owner("Takahiro Harada")]
        [Timeout(2000)]
        [TestMethod()]
        public void Constructor_CreateMicrosoftOfficialBlog()
        {
            var rssFeed = RssFeed.CreateRssFeed("https://blogs.microsoft.com/feed/");
            Assert.IsNotNull(rssFeed);
        }

        // private メソッドをテストする例
        [TestMethod]
        public void GetFeedDispalyName_ReturnString()
        {
            var expected = "RSS : Title (Description)";

            var privateObject = new PrivateObject(typeof(RssFeed));
            var actual = privateObject.Invoke("GetFeedDisplayName", "Title", "Description");
            Assert.AreEqual(expected, actual);
        }

        // static な private メソッドをテストする例
        [TestMethod]
        public void GetRssFeedStream_ReturnStream_IfArgumentExistUrl()
        {
            var privateType = new PrivateType(typeof(RssFeed));
            var actual = privateType.InvokeStatic("GetRssFeedStream", "https://blogs.microsoft.com/feed/");
            Assert.IsInstanceOfType(actual, typeof(Stream));
        }
    }
}
