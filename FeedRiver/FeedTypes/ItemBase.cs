using System;

namespace FeedRiver.FeedTypes
{

	public abstract class ItemBase<T>
	{
		protected ItemBase(string itemTitle,
						   string itemDescription,
						   string itemLink,
						   string itemPubDate,
						   string itemArticleLink,
						   string itemAudioLink,
						   string itemAuthor
						   )
		{
			ItemTitle = itemTitle;
			ItemDescription = itemDescription;
			ItemLink = itemLink;
			ItemPubDate = itemPubDate;
			ItemArticleLink = itemArticleLink;
			ItemAudioLink = itemAudioLink;
			ItemAuthor = itemAuthor;
		}

		protected ItemBase() {}

		public String ItemTitle { get; set; }
		public String ItemDescription { get; set; }
		public String ItemLink { get; set; }
		public String ItemPubDate { get; set; }
		public String ItemArticleLink { get; set; }
		public String ItemAudioLink { get; set; }
		public String ItemAuthor { get; set; }

		//System Vars
		public int ItemRead { get; set; }
		public int ItemUnRead { get; set; }
	}

}