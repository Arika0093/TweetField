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
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 248);
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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