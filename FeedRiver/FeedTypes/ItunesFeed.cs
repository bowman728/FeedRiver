using System;

namespace FeedRiver.FeedTypes
{

	public class ItunesFeed : FeedBase<ItunesFeed>
	{
		public ItunesFeed(string title,
						  string description,
						  string link,
						  string language,
						  string copyRight,
						  string category,
						  string itunesImage,
						  string itunesCategory,
						  string itunesAuthor,
						  string itunesOwnerName,
						  string itunesOwnerEmail,
						  string itunesSubtitle) : base(title,
														description,
														link,
														language,
														copyRight,
														category)
		{
			ItunesImage = itunesImage;
			ItunesCategory = itunesCategory;
			ItunesAuthor = itunesAuthor;
			ItunesOwnerName = itunesOwnerName;
			ItunesOwnerEmail = itunesOwnerEmail;
			ItunesSubtitle = itunesSubtitle;
		}

		public ItunesFeed() {}

		public String ItunesImage { get; set; }
		public String ItunesCategory { get; set; }
		public String ItunesAuthor { get; set; }
		public String ItunesOwnerName { get; set; }
		public String ItunesOwnerEmail { get; set; }
		public String ItunesSubtitle { get; set; }
	}

}