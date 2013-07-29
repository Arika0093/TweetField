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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(-9999, -9999);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(0, 0);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Captcha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(284, 263);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
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

		private System.Windows.Forms.Button button1;
	}
}