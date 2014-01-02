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
	public partial class PostError : Form
	{
		// Constructor
		public PostError(String PostText, String ErrorReason = "")
		{
			// Init
			InitializeComponent();
			// Text Set
			textBox1.Text = (ErrorReason != "" ? ErrorReason : "原因不明のエラー");
			textBox2.Text = PostText;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Ignore;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Retry;
			Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
