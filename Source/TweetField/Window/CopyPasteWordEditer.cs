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
	public partial class CopyPasteWordEditer : Form
	{
		// Setting
		private CopyWords Cw;

		// Init
		public CopyPasteWordEditer(ref CopyWords Cws)
		{
			// Init
			InitializeComponent();
			// Copy
			Cw = Cws;
			// Set
			textBox1.Text = Cw.ShortText;
			//textBox1.Enabled = Cw.IsMenuShow;
			textBox2.Text = Cw.Text.Replace("\n", "\r\n");
			checkBox1.Checked = Cw.IsMenuShow;
			checkBox2.Checked = Cw.IsRandomize;
		}

		// MenuShow Changed
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			// Enable Change
			// textBox1.Enabled = checkBox1.Checked;
		}

		// MainText Edited
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = (textBox2.Text != "");
		}

		// OK Clicked
		private void button1_Click(object sender, EventArgs e)
		{
			// Set
			Cw.ShortText = textBox1.Text;
			Cw.Text = textBox2.Text.Replace("\r", "");
			Cw.IsMenuShow = checkBox1.Checked;
			Cw.IsRandomize = checkBox2.Checked;
			// Result is OK
			DialogResult = DialogResult.OK;
			// Close
			Close();
		}

		// Cancel Clicked
		private void button2_Click(object sender, EventArgs e)
		{
			// Result Cancel
			DialogResult = DialogResult.Cancel;
			// Close
			Close();
		}
	}
}
