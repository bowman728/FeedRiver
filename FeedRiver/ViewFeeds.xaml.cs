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
	public partial class ViewFeeds : Window
	{
		private Func<XAttribute, String> _isAttributeEmpty =
		x => x == null ? "" : (string)x;

		private Func<XElement, String> _isElementEmpty =
		x => x == null ? "" : (string)x;

		public ViewFeeds()
		{
			InitializeComponent();
//			FeedDataGridControl.ItemsSource = FeedList.GetInstance.FeedMasterList;
		}

		private void TestButton_Click(object sender, RoutedEventArgs e)
		{
			XDocument doc =
			XDocument.Load(
						   @"D:\workspace\FeedRiver\FeedRiver\data\Podcasts\quit.xml");


			XNamespace itunes =
			"http://www.itunes.com/dtds/podcast-1.0.dtd";

			IEnumerable<ItunesFeed> feedQuery =
			doc.Root.Elements("channel")
			   .Select(p => new ItunesFeed
								{
								Title = _isElementEmpty(p.Element("title")),
								Description = _isElementEmpty(p.Element("description")),
								Link = _isElementEmpty(p.Element("link")),
								Language = _isElementEmpty(p.Element("language")),
								CopyRight = _isElementEmpty(p.Element("copyright")),
								Category = _isElementEmpty(p.Element("category"))
								});


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
						   }).ToList();

			foreach (ItunesFeed it in feedQuery)
			{
				foreach (ItunesFeedItems itf in itemQuery)
					it.FeedItemsMasterList.Add(itf);

				FeedList.GetInstance.FeedMasterList.Add(it);
			}
		}

		private void TestButton2_Click(object sender, RoutedEventArgs e)
		{
		
			FeedDataGridControl.Items.Refresh();

			TestTextBox.Text += FeedList.GetInstance.FeedMasterList[0].Title +
								Environment.NewLine;

			TestTextBox.Text +=
			FeedList.GetInstance.FeedMasterList[0].FeedItemsMasterList[0]
			.ItemTitle + Environment.NewLine;

			TestTextBox.Text +=
			FeedList.GetInstance.FeedMasterList[0].FeedItemsMasterList[2]
			.ItemTitle
			+ Environment.NewLine;

			TestTextBox.Text +=
			FeedList.GetInstance.FeedMasterList[0].FeedItemsMasterList[4]
			.ItemTitle + Environment.NewLine;
		}
	}

}