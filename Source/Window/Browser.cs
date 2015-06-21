using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TweetField
{
	public partial class Browser : Form
	{
		public Browser(String URL)
		{
			InitializeComponent();
			webBrowser1.Url = new Uri(URL);
			Back.Enabled = false;
			Next.Enabled = false;
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			// Title Changed
			Text = webBrowser1.DocumentTitle;
			URLText.Text = webBrowser1.Url.ToString();
			Back.Enabled = webBrowser1.CanGoBack;
			Next.Enabled = webBrowser1.CanGoForward;
		}

		private void Back_Click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}

		private void Next_Click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}

		private void Go_Click(object sender, EventArgs e)
		{
			webBrowser1.Url = new Uri(URLText.Text);
		}
	}
}
