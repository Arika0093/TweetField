namespace TweetField
{
	partial class Captcha
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Captcha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(284, 263);
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Captcha";
			this.Opacity = 0.7D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Captcha";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Red;
			this.Load += new System.EventHandler(this.Captcha_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Captcha_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Captcha_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Captcha_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Captcha_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion
	}
}