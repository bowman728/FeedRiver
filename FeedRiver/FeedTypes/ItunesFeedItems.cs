using System;
using System.ComponentModel;

namespace FeedRiver.FeedTypes
{

	public class ItunesFeedItems : ItemBase<ItunesFeedItems>
	{
		public ItunesFeedItems() {}

		public ItunesFeedItems(string itemTitle,
							   string itemDescription,
							   string itemLink,
							   string itemPubDate,
							   string itemArticleLink,
							   string itemAudioLink,
							   string itemAuthor,
							   string itunesItemSubTitle,
							   string itunesItemKeyWords,
							   string itunesItemEpisodeNotes,
							   string itunesItemPublishDate,
							   string itunesItemDuration,
							   bool isRead)
		: base(
		itemTitle,
		itemDescription,
		itemLink,
		itemPubDate,
		itemArticleLink,
		itemAudioLink,
		itemAuthor)
		{
			ItunesItemSubTitle = itunesItemSubTitle;
			ItunesItemKeyWords = itunesItemKeyWords;
			ItunesItemEpisodeNotes = itunesItemEpisodeNotes;
			ItunesItemPublishDate = itunesItemPublishDate;
			ItunesItemDuration = itunesItemDuration;
			IsRead = isRead;
		}

		public String ItunesItemSubTitle { get; set; }
		public String ItunesItemKeyWords { get; set; }
		public String ItunesItemEpisodeNotes { get; set; }
		public String ItunesItemPublishDate { get; set; }
		public String ItunesItemDuration { get; set; }
		public bool IsRead { get; set; }

	}

}