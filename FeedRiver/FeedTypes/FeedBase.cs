﻿using System;
using System.ComponentModel;

namespace FeedRiver.FeedTypes
{

	public abstract class FeedBase<T>
	{
		//Feed Vars
		protected FeedBase(string title,
						   string description,
						   string link,
						   string language,
						   string copyRight,
						   string category)
		{
			Title = title;
			Description = description;
			Link = link;
			Language = language;
			CopyRight = copyRight;
			Category = category;
		}

		protected FeedBase() { }
		public String Title { get; set; }
		public String Description { get; set; }
		public String Link { get; set; }
		public String Language { get; set; }
		public String CopyRight { get; set; }

		//Program Variables
		public String Category { get; set; }
		public int TotalReadItems { get; set; }
		public int TotalUnReadItems { get; set; }
		public int TotalAvailableItems { get; set; }
		public virtual BindingList<ItemBase<T>> Items { get; set; }
	}

}