using System;
using System.ComponentModel;
using FeedRiver.FeedTypes;

namespace FeedRiver
{

    public class FeedList
    {
        private static readonly Lazy<FeedList> Instance = new Lazy<FeedList>(() => new FeedList());

        private FeedList() { FeedBindingList = new BindingList<ItunesFeed>(); }

        public static FeedList GetInstance { get { return Instance.Value; } }

        public BindingList<ItunesFeed> FeedBindingList { get; set; }


        
        }

}