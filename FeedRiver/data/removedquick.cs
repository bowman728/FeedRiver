using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using FeedRiver.FeedTypes;

namespace FeedMaster
{
    public class Removedquick 
    {
        private const string ATOM = "http://www.w3.org/2005/Atom/";
        private const string ITUNES = "http://www.itunes.com/dtds/podcast-1.0.dtd";
        private const string RSS = "http://purl.org/rss/1.0/";


        private void DoItButton_Click(object sender, EventArgs e)
        {
            var doc = XDocument.Load(@"D:\workspace\FeedMaster\FeedMaster\data\ItemList\quit.xml");

            XNamespace itunes = "http://www.itunes.com/dtds/podcast-1.0.dtd";

            var query = doc.Root.Elements("channel")
                        .Elements("item")
                        .Select(p => new RssFeed
                        {
                            FeedTitle = p.Element("title").Value
                        }).ToList();
            foreach (var p in query)
            {
                TestTextBox.Text += p.FeedTitle + System.Environment.NewLine;
            }

        }

        private void TestButton_Click_Old(object sender, EventArgs e)
        {
            try
            {

                XDocument doc = XDocument.Load(@"D:\workspace\FeedMaster\FeedMaster\data\podcasts\quit.xml");
                var documentNameSpaces = doc.Element("rss").Attributes().ToList();
                XNamespace ns = LoadNameSpace(documentNameSpaces);
                TestTextBox.Text += ns;


            }
            catch (System.IO.FileNotFoundException fileException)
            {
                TestTextBox.Text += fileException.Message;
            }
            catch (System.NullReferenceException nullException)
            {
                TestTextBox.Text += nullException.TargetSite + " " + nullException.Message;
            }



        }

        private XNamespace LoadNameSpace(IEnumerable<XAttribute> nsList)
        {

            foreach (var testCase in nsList)
            {
                switch (testCase.Value)
                {
                    case RSS:
                        {
                            return RSS;
                            break;
                        }
                    case ATOM:
                        {
                            return ATOM;
                            break;
                        }
                    case ITUNES:
                        {
                            return ITUNES;
                            break;
                        }


                }
            }
            return null;
        }


        private void TestButton_Click(object sender, EventArgs e)
        {

            RssFeed test = new RssFeed();
            TestTextBox.Text += System.Environment.NewLine;
            test.Type = "Rss Podcast Type";
            TestTextBox.Text += test.Type;
            TestTextBox.Text += System.Environment.NewLine;


            ItunesFeed itest = new ItunesFeed();
            TestTextBox.Text += System.Environment.NewLine;
            itest.Type = "Itunes Podcast";
            TestTextBox.Text += itest.Type;
            TestTextBox.Text += System.Environment.NewLine;


        }


    } //End Class




}
