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
	public partial class PictureCheck : Form
	{
		// Init
		public PictureCheck(String PicturePath)
		{
			// Init
			InitializeComponent();
			// Picture Set
			pictureBox1.Load(PicturePath);
			// Change Client Size
			ClientSize = new Size(
				Math.Max(pictureBox1.Image.Width, label1.Width),
				pictureBox1.Image.Height + label1.Height);
		}
		// Closed
		private void PictureCheck_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Dispose
			pictureBox1.Dispose();
		}

		// Clicked
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			// Close
			Close();
		}
	}
}
