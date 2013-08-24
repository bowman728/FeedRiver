using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using FeedRiver.Annotations;
using FeedRiver.FeedTypes;

namespace FeedRiver
{

	public sealed class FeedList : INotifyPropertyChanged
	{
		private static readonly Lazy<FeedList> Instance =
		new Lazy<FeedList>(() => new FeedList());

		private Func<XAttribute, String> _isAttributeEmpty =
		x => x == null ? "" : (string)x;

		private Func<XElement, String> _isElementEmpty =
		x => x == null ? "" : (string)x;

		private ObservableCollection<ItunesFeed> _feedMasterList;

		public FeedList() { FeedMasterList = new ObservableCollection<ItunesFeed>(); }
		public static FeedList GetInstance { get { return Instance.Value; } }
		public ObservableCollection<ItunesFeed> FeedMasterList
		{
			get { return _feedMasterList; }
			set
			{
				if (Equals(value, _feedMasterList)) return;
				_feedMasterList = value;
				OnPropertyChanged();
			}
		}

		public int TotalFeeds { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged(
		[CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}