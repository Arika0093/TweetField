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
		PictureImages Pis;
		int SelIndex = 0;

		// Init
		public PictureCheck(PictureImages Pictures)
		{
			// Init
			InitializeComponent();
			Pis = Pictures;
			// combobox insert
			for(int i = 0; i < Pictures.Size; i++) {
				comboBox1.Items.Add(String.Format("Image {0}: {1}", i+1, Pictures.GetPathWithType(i)));
			}
			// select index
			comboBox1.SelectedIndex = SelIndex;
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

		// Picture Save
		private void button1_Click(object sender, EventArgs e)
		{
			// Save Dialog
			var Dlg = new SaveFileDialog();
			// Set
			Dlg.Filter = "画像形式|*.png;*.jpg;*.bmp;*.gif;*.tif|すべてのファイル|*.*";
			Dlg.DefaultExt = "png";
			// Show
			if(Dlg.ShowDialog() == DialogResult.OK){
				// Save
				pictureBox1.Image.Save(Dlg.FileName);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelIndex = comboBox1.SelectedIndex;
			// Picture Set
			pictureBox1.Load(Pis.GetPath(SelIndex));
			// Size Get
			int Width = Math.Max(pictureBox1.Image.Width, tableLayoutPanel1.Width);
			int Height = Math.Max(pictureBox1.Image.Height, tableLayoutPanel1.Height);
			// Change Client Size
			ClientSize = new Size(Width, Height);
			var Rect = Screen.PrimaryScreen.WorkingArea;
			Location = new Point(Rect.Width/2 - ClientSize.Width/2,
				Rect.Height/2 - ClientSize.Height/2);
		}
	}
}
