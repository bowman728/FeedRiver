using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Xml.Linq;
using FeedRiver.FeedTypes;

namespace FeedRiver
{

	/// <summary>
	///     Interaction logic for FeedRiverTest.xaml
	/// </summary>
	public partial class FeedRiverTest : Window
	{
		private FeedList _feedList = FeedList.GetInstance;

		private Func<XAttribute, String> _isAttributeEmpty =
		x => x == null ? "" : (string)x;

		private Func<XElement, String> _isElementEmpty =
		x => x == null ? "" : (string)x;

		public FeedRiverTest() {InitializeComponent();}

		private void TestButton_Click(object sender, RoutedEventArgs e)
		{
			XDocument doc =
			XDocument.Load(
						   @"D:\workspace\FeedRiver\FeedRiver\data\Podcasts\quit.xml");

			XNamespace itunes =
			"http://www.itunes.com/dtds/podcast-1.0.dtd";

			if (doc.Root == null) return;
			List<ItunesFeed> feedQuery =
			doc.Root.Elements("channel")
			   .Select(p => new ItunesFeed
								{
								Title = _isElementEmpty(p.Element("title")),
								Description = _isElementEmpty(p.Element("description")),
								Link = _isElementEmpty(p.Element("link")),
								Language = _isElementEmpty(p.Element("language")),
								CopyRight = _isElementEmpty(p.Element("copyright")),
								Category = _isElementEmpty(p.Element("category"))
								})
			   .ToList();


			_feedList.FeedBindingList.Add(feedQuery[0]);

			List<ItunesFeedItems> itemQuery =
			doc.Root.Elements("channel")
			   .Elements("item")
			   .Select(
					   p =>
					   new ItunesFeedItems
						   {
						   ItemTitle = _isElementEmpty(p.Element("title")),
						   ItemDescription = _isElementEmpty(p.Element("description")),
						   ItemLink = _isElementEmpty(p.Element("link")),
						   ItemPubDate = _isElementEmpty(p.Element("pubDate")),
						   ItemArticleLink = _isElementEmpty(p.Element("link")),
						   ItemAudioLink =
						   _isAttributeEmpty(p.Element("enclosure").Attribute("url")),
						   ItemAuthor = _isElementEmpty(p.Element("author")),
						   })
			   .ToList();

			itemQuery.ForEach(it =>
							  TestTextBox.Text += it.ItemTitle);

			ItunesFeed initWTF = new ItunesFeed();

			initWTF.FeedItems.
		}

		private void TestButton2_Click(object sender, RoutedEventArgs e)
		{
		}
	}

}