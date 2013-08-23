using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Xml.Linq;
using FeedRiver.FeedTypes;

namespace FeedRiver
{

	public class FeedList
	{
		private static readonly Lazy<FeedList> Instance =
		new Lazy<FeedList>(() => new FeedList());

		private Func<XAttribute, String> _isAttributeEmpty =
		x => x == null ? "" : (string)x;

		private Func<XElement, String> _isElementEmpty =
		x => x == null ? "" : (string)x;

		private FeedList() {FeedBindingList = new BindingList<ItunesFeed>();}
		public static FeedList GetInstance { get { return Instance.Value; } }
		public BindingList<ItunesFeed> FeedBindingList { get; set; }

		public int TotalFeeds { get; set; }

		public void AddNewFeed(XDocument xd)
		{
			
			
		}
	}

}