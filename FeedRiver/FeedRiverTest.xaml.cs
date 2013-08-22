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
		private Func<XElement, String> _isEmpty = x => x == null ? "" : (string)x;
		public FeedRiverTest() {InitializeComponent();}

		private void TestButton_Click(object sender, RoutedEventArgs e)
		{
			XDocument doc =
			XDocument.Load(
						   @"D:\workspace\FeedRiver\FeedRiver\data\Podcasts\quit.xml");

			XNamespace itunes =
			"http://www.itunes.com/dtds/podcast-1.0.dtd";

			if (doc.Root == null) return;
			List<ItunesFeed> query =
			doc.Root.Elements("channel")
			   .Elements("item")
			   .Select(p =>
					   new ItunesFeed
						   {
						   Title = p.Element("title").Value,
						   Description = p.Element("description").Value,
						   Link = _isEmpty(p.Element("link")),
						   })
			   .ToList();


			foreach (ItunesFeed p in query)
			{
				TestTextBox.Text += p.Title + Environment.NewLine;
				TestTextBox.Text += p.Link + Environment.NewLine;
			}
		}

		private void TestButton2_Click(object sender, RoutedEventArgs e)
		{
			XDocument doc =
			XDocument.Load(
						   @"D:\workspace\FeedRiver\FeedRiver\data\Podcasts\quit.xml");

			XNamespace itunes =
			"http://www.itunes.com/dtds/podcast-1.0.dtd";

			List<ItunesFeed> query =
			doc.Root.Elements("channel")
			   .Select(
					   p =>
					   new ItunesFeed
						   {
						   Title = p.Element("title").Value,
						   })
			   .ToList();


			foreach (ItunesFeed p in query)
				TestTextBox.Text += p.Title + Environment.NewLine;
		}
	}

}