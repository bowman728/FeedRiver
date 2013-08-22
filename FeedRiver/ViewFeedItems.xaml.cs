using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Input;

namespace FeedRiver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


		private void ViewFeedButton_Click(object sender, RoutedEventArgs e)
		{
			StartDownload();

		
		}



		private void StartDownload()
		{
			Uri downloadLoc = new Uri("http://www.sciencefriday.com/audio/scifriaudio.xml", UriKind.Absolute);
			WebClient client = new WebClient();
			client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
			client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
			this.Cursor = Cursors.Wait;
			client.DownloadFileAsync(downloadLoc, @"D:\workspace\FeedRiver\FeedRiver\data\blah.xml");
			

		}

		void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			
			double bytesIn = double.Parse(e.BytesReceived.ToString());
			double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
			FeedTextBlock.Text += "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive + Environment.NewLine;
//			DownloadProgressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
			DownloadProgressBar.Value = e.ProgressPercentage;
		}

		void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			this.Cursor = Cursors.Arrow;
			FeedTextBlock.Text += "Completed";
		}

		private void DMethod1()
		{
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("fuckyou.com");



			HttpWebResponse webResponse = (HttpWebResponse)httpRequest.GetResponse();



			Stream sr = webResponse.GetResponseStream();


			StreamReader response = new StreamReader(sr);


		}

    }
}
