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
			this.文字列処理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.テキストを英訳NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.コピペワード編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ハッシュタグの設定HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.画像PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.投稿PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.クリップボードの画像を添付BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.スクリーンショットの投稿SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添付した画像を確認するCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添付画像を破棄するDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.設定ダイアログを開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.投稿ウィンドウを閉じるCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.poltsの終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UserIcon = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 34);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(424, 18);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.PostText, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.UserIcon, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 52);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// PostText
			// 
			this.PostText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PostText.ContextMenuStrip = this.contextMenuStrip1;
			this.PostText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PostText.ForeColor = System.Drawing.SystemColors.WindowText;
			this.PostText.Location = new System.Drawing.Point(35, 0);
			this.PostText.Margin = new System.Windows.Forms.Padding(0);
			this.PostText.Multiline = true;
			this.PostText.Name = "PostText";
			this.PostText.Size = new System.Drawing.Size(389, 34);
			this.PostText.TabIndex = 1;
			this.PostText.TextChanged += new System.EventHandler(this.PostText_TextChanged);
			this.PostText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PostText_KeyDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文字列処理SToolStripMenuItem,
            this.画像PToolStripMenuItem,
            this.toolStripSeparator3,
            this.設定ダイアログを開くOToolStripMenuItem,
            this.toolStripSeparator2,
            this.投稿ウィンドウを閉じるCToolStripMenuItem,
            this.poltsの終了XToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(228, 126);
			// 
			// 文字列処理SToolStripMenuItem
			// 
			this.文字列処理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.テキストを英訳NToolStripMenuItem,
            this.toolStripSeparator4,
            this.コピペワード編集EToolStripMenuItem,
            this.ハッシュタグの設定HToolStripMenuItem});
			this.文字列処理SToolStripMenuItem.Name = "文字列処理SToolStripMenuItem";
			this.文字列処理SToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.文字列処理SToolStripMenuItem.Text = "文字列処理(&S)";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
			// 
			// テキストを英訳NToolStripMenuItem
			// 
			this.テキストを英訳NToolStripMenuItem.Name = "テキストを英訳NToolStripMenuItem";
			this.テキストを英訳NToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.テキストを英訳NToolStripMenuItem.Text = "テキストを翻訳(&T)";
			this.テキストを英訳NToolStripMenuItem.Click += new System.EventHandler(this.テキストを英訳NToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(252, 6);
			// 
			// コピペワード編集EToolStripMenuItem
			// 
			this.コピペワード編集EToolStripMenuItem.Name = "コピペワード編集EToolStripMenuItem";
			this.コピペワード編集EToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.コピペワード編集EToolStripMenuItem.Text = "コピペワード呼び出し/編集(&C)...";
			this.コピペワード編集EToolStripMenuItem.Click += new System.EventHandler(this.コピペワード編集EToolStripMenuItem_Click);
			// 
			// ハッシュタグの設定HToolStripMenuItem
			// 
			this.ハッシュタグの設定HToolStripMenuItem.Name = "ハッシュタグの設定HToolStripMenuItem";
			this.ハッシュタグの設定HToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.ハッシュタグの設定HToolStripMenuItem.Text = "ハッシュタグの設定(&H)...";
			this.ハッシュタグの設定HToolStripMenuItem.Click += new System.EventHandler(this.ハッシュタグの設定HToolStripMenuItem_Click);
			// 
			// 画像PToolStripMenuItem
			// 
			this.画像PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.投稿PToolStripMenuItem,
            this.クリップボードの画像を添付BToolStripMenuItem,
            this.スクリーンショットの投稿SToolStripMenuItem,
            this.添付した画像を確認するCToolStripMenuItem,
            this.添付画像を破棄するDToolStripMenuItem});
			this.画像PToolStripMenuItem.Name = "画像PToolStripMenuItem";
			this.画像PToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.画像PToolStripMenuItem.Text = "画像(&P)";
			// 
			// 投稿PToolStripMenuItem
			// 
			this.投稿PToolStripMenuItem.Name = "投稿PToolStripMenuItem";
			this.投稿PToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.投稿PToolStripMenuItem.Text = "画像を添付する(&P)...";
			this.投稿PToolStripMenuItem.Click += new System.EventHandler(this.投稿PToolStripMenuItem_Click);
			// 
			// クリップボードの画像を添付BToolStripMenuItem
			// 
			this.クリップボードの画像を添付BToolStripMenuItem.Name = "クリップボードの画像を添付BToolStripMenuItem";
			this.クリップボードの画像を添付BToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.クリップボードの画像を添付BToolStripMenuItem.Text = "クリップボードの画像を添付(&B)";
			this.クリップボードの画像を添付BToolStripMenuItem.Click += new System.EventHandler(this.クリップボードの画像を添付BToolStripMenuItem_Click);
			// 
			// スクリーンショットの投稿SToolStripMenuItem
			// 
			this.スクリーンショットの投稿SToolStripMenuItem.Name = "スクリーンショットの投稿SToolStripMenuItem";
			this.スクリーンショットの投稿SToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.スクリーンショットの投稿SToolStripMenuItem.Text = "スクリーンショットの投稿(&S)...";
			this.スクリーンショットの投稿SToolStripMenuItem.Click += new System.EventHandler(this.スクリーンショットの投稿SToolStripMenuItem_Click);
			// 
			// 添付した画像を確認するCToolStripMenuItem
			// 
			this.添付した画像を確認するCToolStripMenuItem.Name = "添付した画像を確認するCToolStripMenuItem";
			this.添付した画像を確認するCToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.添付した画像を確認するCToolStripMenuItem.Text = "添付した画像を確認する(&C)...";
			this.添付した画像を確認するCToolStripMenuItem.Visible = false;
			this.添付した画像を確認するCToolStripMenuItem.Click += new System.EventHandler(this.添付した画像を確認するCToolStripMenuItem_Click);
			// 
			// 添付画像を破棄するDToolStripMenuItem
			// 
			this.添付画像を破棄するDToolStripMenuItem.Name = "添付画像を破棄するDToolStripMenuItem";
			this.添付画像を破棄するDToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.添付画像を破棄するDToolStripMenuItem.Text = "添付画像を破棄する(&D)";
			this.添付画像を破棄するDToolStripMenuItem.Visible = false;
			this.添付画像を破棄するDToolStripMenuItem.Click += new System.EventHandler(this.添付画像を破棄するDToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
			// 
			// 設定ダイアログを開くOToolStripMenuItem
			// 
			this.設定ダイアログを開くOToolStripMenuItem.Name = "設定ダイアログを開くOToolStripMenuItem";
			this.設定ダイアログを開くOToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.設定ダイアログを開くOToolStripMenuItem.Text = "設定ダイアログを開く(&O)...";
			this.設定ダイアログを開くOToolStripMenuItem.Click += new System.EventHandler(this.設定ダイアログを開くOToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
			// 
			// 投稿ウィンドウを閉じるCToolStripMenuItem
			// 
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Name = "投稿ウィンドウを閉じるCToolStripMenuItem";
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Text = "投稿ウィンドウを閉じる(&E)";
			this.投稿ウィンドウを閉じるCToolStripMenuItem.Click += new System.EventHandler(this.投稿ウィンドウを閉じるCToolStripMenuItem_Click);
			// 
			// poltsの終了XToolStripMenuItem
			// 
			this.poltsの終了XToolStripMenuItem.Name = "poltsの終了XToolStripMenuItem";
			this.poltsの終了XToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.poltsの終了XToolStripMenuItem.Text = "アプリケーションの終了(&X)";
			this.poltsの終了XToolStripMenuItem.Click += new System.EventHandler(this.poltsの終了XToolStripMenuItem_Click);
			// 
			// UserIcon
			// 
			this.UserIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.UserIcon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UserIcon.Location = new System.Drawing.Point(1, 1);
			this.UserIcon.Margin = new System.Windows.Forms.Padding(1);
			this.UserIcon.Name = "UserIcon";
			this.UserIcon.Size = new System.Drawing.Size(33, 32);
			this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.UserIcon.TabIndex = 2;
			this.UserIcon.TabStop = false;
			this.UserIcon.Click += new System.EventHandler(this.UserIcon_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(426, 54);
			this.panel1.TabIndex = 2;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "TwiField";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// Post
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(426, 54);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
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
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 投稿PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem スクリーンショットの投稿SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem クリップボードの画像を添付BToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 設定ダイアログを開くOToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 投稿ウィンドウを閉じるCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem poltsの終了XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添付画像を破棄するDToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.TextBox PostText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem 添付した画像を確認するCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 画像PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 文字列処理SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ハッシュタグの設定HToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem コピペワード編集EToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem テキストを英訳NToolStripMenuItem;
		private System.Windows.Forms.PictureBox UserIcon;
	}
}