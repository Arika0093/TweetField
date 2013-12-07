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
	public partial class Captcha : Form
	{
		private Rectangle CapTriangle;
		private Point CapStart = new Point(), CapLocal = new Point();
		private bool IsMousePush;

		public Captcha()
		{
			InitializeComponent();
		}

		public Rectangle GetCaptcha()
		{
			// Call Dialog
			ShowDialog();
			// Set Rectangle
			CapTriangle = new Rectangle(
				Math.Min(CapStart.X-1,CapStart.X+CapLocal.X-1), 
				Math.Min(CapStart.Y-1,CapStart.Y+CapLocal.Y-1),
				Math.Abs(CapLocal.X), Math.Abs(CapLocal.Y));
			// if Size Sum <= 30
			if(CapTriangle.Width + CapTriangle.Height <= 30){
				// Return Null
				return new Rectangle( 0, 0, 0, 0);
			}
			// Return
			return CapTriangle;
		}

		// Load
		private void Captcha_Load(object sender, EventArgs e)
		{
			// Get Space
			Rectangle WorkSpace = Screen.GetBounds(this);
			// Set Size
			Width		= WorkSpace.Right - WorkSpace.Left;
			Height		= WorkSpace.Bottom - WorkSpace.Top;
			// Set Location
			Location	= new Point(WorkSpace.Left, WorkSpace.Top);
			// Z Index Change
			TopLevel	= true;
			TopMost		= true;
		}

		// Start
		private void Captcha_MouseDown(object sender, MouseEventArgs e)
		{
			// Set Point
			CapStart	= e.Location;
			IsMousePush	= true;
		}

		// Moving
		private void Captcha_MouseMove(object sender, MouseEventArgs e)
		{
			// If not Mouse Push
			if(IsMousePush == false){
				// End
				return;
			}
			// Set Location
			CapLocal.X = e.Location.X - CapStart.X;
			CapLocal.Y = e.Location.Y - CapStart.Y;
			// Drawing
			Invalidate();
		}

		// End
		private void Captcha_MouseUp(object sender, MouseEventArgs e)
		{
			// Set Location
			CapLocal.X = e.Location.X - CapStart.X;
			CapLocal.Y = e.Location.Y - CapStart.Y;
			// Form End
			Close();
		}

		// Drawing
		private void Captcha_Paint(object sender, PaintEventArgs e)
		{
			// Draw Penk All of White
			e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);
			// Draw Triangle Mouse Moving Point of Red(Transparent Key)
			e.Graphics.FillRectangle(Brushes.Red,
				Math.Min(CapStart.X-1,CapStart.X+CapLocal.X-1), 
				Math.Min(CapStart.Y-1,CapStart.Y+CapLocal.Y-1),
				Math.Abs(CapLocal.X), Math.Abs(CapLocal.Y));
			// Draw Triangle Mouse Moving Point of Black
			e.Graphics.DrawRectangle(Pens.Black,
				Math.Min(CapStart.X-1,CapStart.X+CapLocal.X-1), 
				Math.Min(CapStart.Y-1,CapStart.Y+CapLocal.Y-1),
				Math.Abs(CapLocal.X), Math.Abs(CapLocal.Y));
		}

		// Exit
		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
