namespace TweetField
{
	partial class Browser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.URLText = new System.Windows.Forms.TextBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.Back = new System.Windows.Forms.Button();
			this.Next = new System.Windows.Forms.Button();
			this.Go = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Controls.Add(this.Go, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Next, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.URLText, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Back, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 511);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// URLText
			// 
			this.URLText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.URLText.Location = new System.Drawing.Point(73, 3);
			this.URLText.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.URLText.Name = "URLText";
			this.URLText.Size = new System.Drawing.Size(895, 25);
			this.URLText.TabIndex = 1;
			// 
			// webBrowser1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.webBrowser1, 4);
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 33);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(1002, 475);
			this.webBrowser1.TabIndex = 2;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			// 
			// Back
			// 
			this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Back.Location = new System.Drawing.Point(3, 3);
			this.Back.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(31, 26);
			this.Back.TabIndex = 3;
			this.Back.Text = "←";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Next
			// 
			this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Next.Location = new System.Drawing.Point(36, 3);
			this.Next.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(31, 26);
			this.Next.TabIndex = 4;
			this.Next.Text = "→";
			this.Next.UseVisualStyleBackColor = true;
			this.Next.Click += new System.EventHandler(this.Next_Click);
			// 
			// Go
			// 
			this.Go.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Go.Location = new System.Drawing.Point(969, 3);
			this.Go.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
			this.Go.Name = "Go";
			this.Go.Size = new System.Drawing.Size(36, 26);
			this.Go.TabIndex = 5;
			this.Go.Text = "Go";
			this.Go.UseVisualStyleBackColor = true;
			this.Go.Click += new System.EventHandler(this.Go_Click);
			// 
			// Browser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 511);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Browser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simple Browser";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox URLText;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button Go;
		private System.Windows.Forms.Button Next;
		private System.Windows.Forms.Button Back;
	}
}