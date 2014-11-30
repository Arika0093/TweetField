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
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			// Title Changed
			Text = webBrowser1.DocumentTitle;
			URLText.Text = webBrowser1.Url.ToString();
		}
	}
}
