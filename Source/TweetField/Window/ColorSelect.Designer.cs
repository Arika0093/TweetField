namespace TweetField
{
	partial class ColorSelect
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
			this.label1 = new System.Windows.Forms.Label();
			this.SelectedColorNameEdit = new System.Windows.Forms.TextBox();
			this.OK = new System.Windows.Forms.Button();
			this.ColorList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SelectedColorNameEdit, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.OK, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.ColorList, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 294);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "選択色:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SelectedColorNameEdit
			// 
			this.SelectedColorNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectedColorNameEdit.Location = new System.Drawing.Point(64, 3);
			this.SelectedColorNameEdit.Name = "SelectedColorNameEdit";
			this.SelectedColorNameEdit.ReadOnly = true;
			this.SelectedColorNameEdit.Size = new System.Drawing.Size(265, 25);
			this.SelectedColorNameEdit.TabIndex = 1;
			// 
			// OK
			// 
			this.OK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OK.Enabled = false;
			this.OK.Location = new System.Drawing.Point(335, 3);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(78, 24);
			this.OK.TabIndex = 2;
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OK_Click);
			// 
			// ColorList
			// 
			this.ColorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.tableLayoutPanel1.SetColumnSpan(this.ColorList, 3);
			this.ColorList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ColorList.FullRowSelect = true;
			this.ColorList.GridLines = true;
			this.ColorList.HideSelection = false;
			this.ColorList.Location = new System.Drawing.Point(3, 33);
			this.ColorList.MultiSelect = false;
			this.ColorList.Name = "ColorList";
			this.ColorList.Size = new System.Drawing.Size(410, 258);
			this.ColorList.TabIndex = 3;
			this.ColorList.UseCompatibleStateImageBehavior = false;
			this.ColorList.View = System.Windows.Forms.View.Details;
			this.ColorList.SelectedIndexChanged += new System.EventHandler(this.ColorList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Color";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 242;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "RGB";
			this.columnHeader3.Width = 85;
			// 
			// ColorSelect
			// 
			this.AcceptButton = this.OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 294);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ColorSelect";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "色選択ダイアログ";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SelectedColorNameEdit;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.ListView ColorList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}