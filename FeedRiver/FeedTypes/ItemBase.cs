using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedRiver.FeedTypes
{
	public abstract class ItemBase<T>
	{
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
