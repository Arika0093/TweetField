﻿namespace TweetField
{
	partial class Account
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.FollowAuther = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ConsSecret = new System.Windows.Forms.TextBox();
			this.ConsKey = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.StartOAuth = new System.Windows.Forms.Button();
			this.PINEdit = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.AddAccount = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.FollowAuther, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.ConsSecret, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.ConsKey, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.StartOAuth, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.PINEdit, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.AddAccount, 1, 7);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 244);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// FollowAuther
			// 
			this.FollowAuther.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.FollowAuther, 2);
			this.FollowAuther.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FollowAuther.Location = new System.Drawing.Point(158, 175);
			this.FollowAuther.Name = "FollowAuther";
			this.FollowAuther.Size = new System.Drawing.Size(320, 26);
			this.FollowAuther.TabIndex = 1;
			this.FollowAuther.Text = "作者アカウント(@Arika0093)をフォロー";
			this.FollowAuther.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 172);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(149, 32);
			this.label8.TabIndex = 12;
			this.label8.Text = "3. オプション: ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(158, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 32);
			this.label7.TabIndex = 10;
			this.label7.Text = "Secret:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ConsSecret
			// 
			this.ConsSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ConsSecret.Location = new System.Drawing.Point(230, 71);
			this.ConsSecret.Name = "ConsSecret";
			this.ConsSecret.Size = new System.Drawing.Size(248, 25);
			this.ConsSecret.TabIndex = 8;
			// 
			// ConsKey
			// 
			this.ConsKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ConsKey.Location = new System.Drawing.Point(230, 39);
			this.ConsKey.Name = "ConsKey";
			this.ConsKey.Size = new System.Drawing.Size(248, 25);
			this.ConsKey.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(149, 40);
			this.label5.TabIndex = 4;
			this.label5.Text = "4. アカウント登録: ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 36);
			this.label4.Name = "label4";
			this.tableLayoutPanel1.SetRowSpan(this.label4, 2);
			this.label4.Size = new System.Drawing.Size(149, 64);
			this.label4.TabIndex = 3;
			this.label4.Text = "0. API Key Override:\r\n（上級者向け/省略可能）";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "2. PINキー入力: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(475, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "アカウント認証";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "1. 認証登録: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// StartOAuth
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.StartOAuth, 2);
			this.StartOAuth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StartOAuth.Location = new System.Drawing.Point(158, 103);
			this.StartOAuth.Name = "StartOAuth";
			this.StartOAuth.Size = new System.Drawing.Size(320, 34);
			this.StartOAuth.TabIndex = 5;
			this.StartOAuth.Text = "認証開始（ブラウザが開きます）";
			this.StartOAuth.UseVisualStyleBackColor = true;
			this.StartOAuth.Click += new System.EventHandler(this.StartOAuth_Click);
			// 
			// PINEdit
			// 
			this.PINEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.PINEdit, 2);
			this.PINEdit.Enabled = false;
			this.PINEdit.Location = new System.Drawing.Point(158, 143);
			this.PINEdit.Name = "PINEdit";
			this.PINEdit.Size = new System.Drawing.Size(320, 25);
			this.PINEdit.TabIndex = 6;
			this.PINEdit.TextChanged += new System.EventHandler(this.PINEdit_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(158, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 32);
			this.label6.TabIndex = 9;
			this.label6.Text = "Key:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AddAccount
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.AddAccount, 2);
			this.AddAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddAccount.Enabled = false;
			this.AddAccount.Location = new System.Drawing.Point(158, 207);
			this.AddAccount.Name = "AddAccount";
			this.AddAccount.Size = new System.Drawing.Size(320, 34);
			this.AddAccount.TabIndex = 11;
			this.AddAccount.Text = "アカウント登録を行う";
			this.AddAccount.UseVisualStyleBackColor = true;
			this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
			// 
			// Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(481, 244);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Account";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "認証";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox ConsSecret;
		private System.Windows.Forms.TextBox ConsKey;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button StartOAuth;
		private System.Windows.Forms.TextBox PINEdit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button AddAccount;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox FollowAuther;
	}
}