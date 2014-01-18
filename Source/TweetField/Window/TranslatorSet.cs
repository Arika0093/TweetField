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
	public partial class TranslatorSet : Form
	{
		// Setting
		private ApplicationSetting As;

		// Constructor
		public TranslatorSet(ref ApplicationSetting Aps)
		{
			// Init
			InitializeComponent();
			// Copy
			As = Aps;
			// Set
			textBox1.Text = Aps.ConsumerID;
			textBox2.Text = Aps.ClientSecret;
		}

		// OK
		private void button3_Click(object sender, EventArgs e)
		{
			// If Empty
			if(textBox1.Text == "" || textBox2.Text == ""){
				// Show Message
				MessageBox.Show("両方の項目を入力してください．");
				// Nothing
				return;
			}
			// Copy
			As.ConsumerID = textBox1.Text;
			As.ClientSecret = textBox2.Text;
			// Close
			Close();
		}

		// Cancel
		private void button4_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
