namespace TweetField
{
	partial class CopyPasteView
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.Call = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.Controls.Add(this.button3, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.button2, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button5, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.button4, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Call, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 348);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Highlight;
			this.tableLayoutPanel1.SetColumnSpan(this.label3, 4);
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.ForeColor = System.Drawing.SystemColors.Window;
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(453, 32);
			this.label3.TabIndex = 9;
			this.label3.Text = "コピペワード一覧";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button5
			// 
			this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button5.Location = new System.Drawing.Point(369, 317);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(87, 28);
			this.button5.TabIndex = 5;
			this.button5.Text = "取消(&R)";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button4.Location = new System.Drawing.Point(276, 317);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(87, 28);
			this.button4.TabIndex = 4;
			this.button4.Text = "決定(&O)";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// listBox1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.listBox1, 4);
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new System.Drawing.Point(3, 38);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(453, 240);
			this.listBox1.TabIndex = 3;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Call
			// 
			this.Call.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Call.Enabled = false;
			this.Call.Location = new System.Drawing.Point(3, 284);
			this.Call.Name = "Call";
			this.tableLayoutPanel1.SetRowSpan(this.Call, 2);
			this.Call.Size = new System.Drawing.Size(174, 61);
			this.Call.TabIndex = 10;
			this.Call.Text = "呼び出し(&C)";
			this.Call.UseVisualStyleBackColor = true;
			this.Call.Click += new System.EventHandler(this.Call_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(276, 284);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 27);
			this.button2.TabIndex = 11;
			this.button2.Text = "編集(&E)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(369, 284);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 27);
			this.button3.TabIndex = 12;
			this.button3.Text = "削除(&D)";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(183, 284);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 27);
			this.button1.TabIndex = 13;
			this.button1.Text = "新規登録(&N)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// CopyPasteView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 348);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CopyPasteView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "コピペワード呼び出し/一覧";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Call;
		private System.Windows.Forms.Button button1;
	}
}