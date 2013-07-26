namespace TweetField
{
	partial class Background
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Background));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.投稿PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.各種設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.アプリケーションの終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Powerful Continent";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.投稿PToolStripMenuItem,
            this.各種設定SToolStripMenuItem,
            this.toolStripSeparator1,
            this.アプリケーションの終了XToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(155, 76);
			// 
			// 投稿PToolStripMenuItem
			// 
			this.投稿PToolStripMenuItem.Name = "投稿PToolStripMenuItem";
			this.投稿PToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.投稿PToolStripMenuItem.Text = "投稿(&P)...";
			this.投稿PToolStripMenuItem.Click += new System.EventHandler(this.投稿PToolStripMenuItem_Click);
			// 
			// 各種設定SToolStripMenuItem
			// 
			this.各種設定SToolStripMenuItem.Name = "各種設定SToolStripMenuItem";
			this.各種設定SToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.各種設定SToolStripMenuItem.Text = "各種設定(&S)...";
			this.各種設定SToolStripMenuItem.Click += new System.EventHandler(this.各種設定SToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
			// 
			// アプリケーションの終了XToolStripMenuItem
			// 
			this.アプリケーションの終了XToolStripMenuItem.Name = "アプリケーションの終了XToolStripMenuItem";
			this.アプリケーションの終了XToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.アプリケーションの終了XToolStripMenuItem.Text = "終了(&X)";
			this.アプリケーションの終了XToolStripMenuItem.Click += new System.EventHandler(this.アプリケーションの終了XToolStripMenuItem_Click);
			// 
			// Background
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(75, 90);
			this.ControlBox = false;
			this.Enabled = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(-9999, -9999);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Background";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Background";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Background_FormClosing);
			this.Load += new System.EventHandler(this.Background_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 投稿PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 各種設定SToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem アプリケーションの終了XToolStripMenuItem;
	}
}