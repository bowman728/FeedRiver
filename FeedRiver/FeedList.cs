using System;
using System.Collections.Generic;
using System.ComponentModel;
using FeedRiver.FeedTypes;

namespace FeedRiver
{

    public class FeedList
    {
        private static readonly Lazy<FeedList> Instance = new Lazy<FeedList>(() => new FeedList());

        private FeedList() { FeedBindingList = new List<ItunesFeed>(); }

        public static FeedList GetInstance { get { return Instance.Value; } }

        public List<ItunesFeed> FeedBindingList { get; set; }


        
        }

}