using System;

namespace FeedRiver.FeedTypes
{

	public class ItunesFeedItems
	{
		public String ItemTitle { get; set; }

		public String ItemSubTitle { get; set; }

		public String ItemKeyWords { get; set; }

		public String ItemAuthor { get; set; }

		public String ItemDescription { get; set; }

		public String ItemEpisodeNotes { get; set; }

		public DateTime ItemPublishDate { get; set; }

		public String ItemAudioLink { get; set; }

		public TimeSpan ItemDuration { get; set; }

		public String ItemArticleLink { get; set; }

		public bool IsRead { get; set; }
	}

}