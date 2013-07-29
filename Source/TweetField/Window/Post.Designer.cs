namespace TweetField
{
	partial class Post
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.PostText = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.投稿PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.スクリーンショットの投稿SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.クリップボードの画像を添付BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添付画像を破棄するDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.設定ダイアログを開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.投稿ウィンドウを閉じるCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.poltsの終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 41);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(431, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.PostText, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 61);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// PostText
			// 
			this.PostText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PostText.ContextMenuStrip = this.contextMenuStrip1;
			this.PostText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PostText.ForeColor = System.Drawing.SystemColors.WindowText;
			this.PostText.Location = new System.Drawing.Point(0, 0);
			this.PostText.Margin = new System.Windows.Forms.Padding(0);
			this.PostText.Multiline = true;
			this.PostText.Name = "PostText";
			this.PostText.Size = new System.Drawing.Size(431, 41);
			this.PostText.TabIndex = 1;
			this.PostText.TextChanged += new System.EventHandler(this.PostText_TextChanged);
			this.PostText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PostText_KeyDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.投稿PToolStripMenuItem,
            this.スクリーンショットの投稿SToolStripMenuItem,
            this.クリップボードの画像を添付BToolStripMenuItem,
            this.添付画像を破棄するDToolStripMenuItem,
            this.toolStripSeparator1,
            this.設定ダイアログを開くOToolStripMenuItem,
            this.toolStripSeparator2,
            this.投稿ウィンドウを閉じるCToolStripMenuItem,
            this.poltsの終了XToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(251, 170);
			// 
			// 投稿PToolStripMenuItem
			// 
			this.投稿PToolStripMenuItem.Name = "投稿PToolStripMenuItem";
			this.投稿PToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.投稿PToolStripMenuItem.Text = "画像を添付する(&P)...";
			this.投稿PToolStripMenuItem.Click += new System.EventHandler(this.投稿PToolStripMenuItem_Click);
			// 
			// スクリーンショットの投稿SToolStripMenuItem
			// 
			this.スクリーンショットの投稿SToolStripMenuItem.Name = "スクリーンショットの投稿SToolStripMenuItem";
			this.スクリーンショットの投稿SToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.スクリーンショットの投稿SToolStripMenuItem.Text = "スクリーンショットの投稿(&S)...";
			this.スクリーンショットの投稿SToolStripMenuItem.Click += new System.EventHandler(this.スクリーンショットの投稿SToolStripMenuItem_Click);
			// 
			// クリップボードの画像を添付BToolStripMenuItem
			// 
			this.クリップボードの画像を添付BToolStripMenuItem.Name = "クリップボードの画像を添付BToolStripMenuItem";
			this.クリップボードの画像を添付BToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.クリップボードの画像を添付BToolStripMenuItem.Text = "クリップボードの画像を添付(&B)";
			this.クリップボードの画像を添付BToolStripMenuItem.Click += new System.EventHandler(this.クリップボードの画像を添付BToolStripMenuItem_Click);
			// 
			// 添付画像を破棄するDToolStripMenuItem
			// 
			this.添付画像を破棄するDToolStripMenuItem.Enabled = false;
			this.添付画像を破棄するDToolStripMenuItem.Name = "添付画像を破棄するDToolStripMenuItem";
			this.添付画像を破棄するDToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.添付画像を破棄するDToolStripMenuItem.Text = "添付画像を破棄する(&D)";
			this.添付画像を破棄するDToolStripMenuItem.Click += new System.EventHandler(this.添付画像を破棄するDToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
			// 
			// 設定ダイアログを開くOToolStripMenuItem
			// 
			this.設定ダイアログを開くOToolStripMenuItem.Name = "設定ダイアログを開くOToolStripMenuItem";
			this.設定ダイアログを開くOToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.設定ダイアログを開くOToolStripMenuItem.Text = "設定ダイアログを開く(&O)...";
			this.設定ダイアログを開くOToolStripMenuItem.Click += new System.EventHandler(this.設定ダイアログを開くOToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
			// 
			// 投稿ウィンドウを閉じるCToolStripMenuItem
			// 
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Name = "投稿ウィンドウを閉じるCToolStripMenuItem";
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Text = "投稿ウィンドウを閉じる(&E)";
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Click += new System.EventHandler(this.投稿ウィンドウを閉じるCToolStripMenuItem_Click);
			// 
			// poltsの終了XToolStripMenuItem
			// 
			this.poltsの終了XToolStripMenuItem.Name = "poltsの終了XToolStripMenuItem";
			this.poltsの終了XToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.poltsの終了XToolStripMenuItem.Text = "アプリケーションの終了(&X)";
			this.poltsの終了XToolStripMenuItem.Click += new System.EventHandler(this.poltsの終了XToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(433, 63);
			this.panel1.TabIndex = 2;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Powerful Continent";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// Post
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(433, 63);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(209, 46);
			this.Name = "Post";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.PostText_Enter);
			this.Deactivate += new System.EventHandler(this.PostText_Leave);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Post_FormClosing);
			this.Load += new System.EventHandler(this.Post_Load);
			this.Resize += new System.EventHandler(this.Post_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox PostText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 投稿PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem スクリーンショットの投稿SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem クリップボードの画像を添付BToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 設定ダイアログを開くOToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 投稿ウィンドウを閉じるCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem poltsの終了XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添付画像を破棄するDToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}