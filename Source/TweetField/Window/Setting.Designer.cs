namespace TweetField
{
	partial class Setting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.AccountDelete = new System.Windows.Forms.Button();
			this.AccountAdd = new System.Windows.Forms.Button();
			this.PostUserAccount = new System.Windows.Forms.ComboBox();
			this.SettingKey = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.TfExit = new System.Windows.Forms.Button();
			this.PostKey = new System.Windows.Forms.ComboBox();
			this.RentouKaihi = new System.Windows.Forms.CheckBox();
			this.ShowRegulationInfo = new System.Windows.Forms.CheckBox();
			this.ChangeAcc = new System.Windows.Forms.CheckBox();
			this.TextSave = new System.Windows.Forms.CheckBox();
			this.BackgroundColorEdit = new System.Windows.Forms.Button();
			this.IsGradation = new System.Windows.Forms.CheckBox();
			this.StringColorEdit = new System.Windows.Forms.Button();
			this.FontSetting = new System.Windows.Forms.Button();
			this.ShowPosition = new System.Windows.Forms.ComboBox();
			this.HideFormAfterTweet = new System.Windows.Forms.CheckBox();
			this.HideOffFocus = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label8 = new System.Windows.Forms.Label();
			this.ShowHideKey = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.BackgroundColorText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BackgroundColorView = new System.Windows.Forms.Panel();
			this.StringColorText = new System.Windows.Forms.TextBox();
			this.StringColorView = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.FontSize = new System.Windows.Forms.TextBox();
			this.FontName = new System.Windows.Forms.TextBox();
			this.FontColor = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.ApplicationVersion = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.AutoTextSplit = new System.Windows.Forms.CheckBox();
			this.SplitAtPoint = new System.Windows.Forms.CheckBox();
			this.SplitInsertNext = new System.Windows.Forms.CheckBox();
			this.IsIconShow = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// AccountDelete
			// 
			this.AccountDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AccountDelete.Location = new System.Drawing.Point(350, 69);
			this.AccountDelete.Name = "AccountDelete";
			this.AccountDelete.Size = new System.Drawing.Size(117, 26);
			this.AccountDelete.TabIndex = 4;
			this.AccountDelete.Text = "アカウント削除";
			this.toolTip1.SetToolTip(this.AccountDelete, "現在選択中のアカウントを削除します。");
			this.AccountDelete.UseVisualStyleBackColor = true;
			this.AccountDelete.Click += new System.EventHandler(this.AccountDelete_Click);
			// 
			// AccountAdd
			// 
			this.AccountAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AccountAdd.Location = new System.Drawing.Point(203, 69);
			this.AccountAdd.Name = "AccountAdd";
			this.AccountAdd.Size = new System.Drawing.Size(141, 26);
			this.AccountAdd.TabIndex = 3;
			this.AccountAdd.Text = "アカウント追加";
			this.toolTip1.SetToolTip(this.AccountAdd, "TwiFieldで使用するアカウントを追加します。");
			this.AccountAdd.UseVisualStyleBackColor = true;
			this.AccountAdd.Click += new System.EventHandler(this.AccountAdd_Click);
			// 
			// PostUserAccount
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.PostUserAccount, 3);
			this.PostUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PostUserAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PostUserAccount.FormattingEnabled = true;
			this.PostUserAccount.Location = new System.Drawing.Point(119, 39);
			this.PostUserAccount.Name = "PostUserAccount";
			this.PostUserAccount.Size = new System.Drawing.Size(348, 26);
			this.PostUserAccount.TabIndex = 2;
			this.toolTip1.SetToolTip(this.PostUserAccount, "投稿を行うアカウントを選択します。");
			this.PostUserAccount.SelectedIndexChanged += new System.EventHandler(this.PostUserAccount_SelectedIndexChanged);
			// 
			// SettingKey
			// 
			this.SettingKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SettingKey.Location = new System.Drawing.Point(358, 39);
			this.SettingKey.Name = "SettingKey";
			this.SettingKey.Size = new System.Drawing.Size(109, 26);
			this.SettingKey.TabIndex = 55;
			this.SettingKey.Text = "キーを指定";
			this.toolTip1.SetToolTip(this.SettingKey, "ショートカットキーを指定します。ここで指定したキーを押すことで\r\n投稿ウインドウを瞬時に表示させることができます。");
			this.SettingKey.UseVisualStyleBackColor = true;
			this.SettingKey.Click += new System.EventHandler(this.SettingKey_Click);
			// 
			// OK
			// 
			this.OK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OK.Location = new System.Drawing.Point(23, 308);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(243, 33);
			this.OK.TabIndex = 37;
			this.OK.Text = "保存(&S)";
			this.toolTip1.SetToolTip(this.OK, "設定を保存してウインドウを閉じます．");
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OK_Click);
			// 
			// Cancel
			// 
			this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cancel.Location = new System.Drawing.Point(272, 308);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(102, 33);
			this.Cancel.TabIndex = 38;
			this.Cancel.Text = "キャンセル(&C)";
			this.toolTip1.SetToolTip(this.Cancel, "設定を保存せずにウインドウを閉じます．");
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// TfExit
			// 
			this.TfExit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TfExit.Location = new System.Drawing.Point(380, 308);
			this.TfExit.Name = "TfExit";
			this.TfExit.Size = new System.Drawing.Size(107, 33);
			this.TfExit.TabIndex = 39;
			this.TfExit.Text = "終了(&X)";
			this.toolTip1.SetToolTip(this.TfExit, "TwiFieldを終了します．");
			this.TfExit.UseVisualStyleBackColor = true;
			this.TfExit.Click += new System.EventHandler(this.TfExit_Click);
			// 
			// PostKey
			// 
			this.PostKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PostKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PostKey.FormattingEnabled = true;
			this.PostKey.Items.AddRange(new object[] {
            "Enter",
            "Ctrl + Enter",
            "Shift + Enter",
            "Alt + Enter"});
			this.PostKey.Location = new System.Drawing.Point(87, 39);
			this.PostKey.Name = "PostKey";
			this.PostKey.Size = new System.Drawing.Size(380, 26);
			this.PostKey.TabIndex = 40;
			this.toolTip1.SetToolTip(this.PostKey, "ウインドウがアクティブな時に、ここで指定したキーを押すことで\r\nテキストボックス内の内容を呟きます。");
			this.PostKey.Click += new System.EventHandler(this.PostKey_SelectedIndexChanged);
			// 
			// RentouKaihi
			// 
			this.RentouKaihi.AutoSize = true;
			this.RentouKaihi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RentouKaihi.Location = new System.Drawing.Point(87, 191);
			this.RentouKaihi.Name = "RentouKaihi";
			this.RentouKaihi.Size = new System.Drawing.Size(380, 18);
			this.RentouKaihi.TabIndex = 42;
			this.RentouKaihi.Text = "自動で連投回避する";
			this.toolTip1.SetToolTip(this.RentouKaihi, "同じ内容をつぶやこうとした場合に自動で全角スペースを付加して\r\n連投を可能にします。");
			this.RentouKaihi.UseVisualStyleBackColor = true;
			this.RentouKaihi.Click += new System.EventHandler(this.RentouKaihi_CheckedChanged);
			// 
			// ShowRegulationInfo
			// 
			this.ShowRegulationInfo.AutoSize = true;
			this.ShowRegulationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ShowRegulationInfo.Location = new System.Drawing.Point(87, 71);
			this.ShowRegulationInfo.Name = "ShowRegulationInfo";
			this.ShowRegulationInfo.Size = new System.Drawing.Size(380, 18);
			this.ShowRegulationInfo.TabIndex = 41;
			this.ShowRegulationInfo.Text = "残規制情報を利用/表示する";
			this.toolTip1.SetToolTip(this.ShowRegulationInfo, "あと何回投稿したら規制されるかを表示します。\r\nやや重い動作ですので、気になる方はチェックを外してください。");
			this.ShowRegulationInfo.UseVisualStyleBackColor = true;
			this.ShowRegulationInfo.Click += new System.EventHandler(this.ShowRegulationInfo_CheckedChanged);
			// 
			// ChangeAcc
			// 
			this.ChangeAcc.AutoSize = true;
			this.ChangeAcc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChangeAcc.Location = new System.Drawing.Point(87, 95);
			this.ChangeAcc.Name = "ChangeAcc";
			this.ChangeAcc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.ChangeAcc.Size = new System.Drawing.Size(380, 18);
			this.ChangeAcc.TabIndex = 43;
			this.ChangeAcc.Text = "規制されたら自動でアカウントを切り替える";
			this.toolTip1.SetToolTip(this.ChangeAcc, "もし投稿規制になった時に、登録してあるアカウントの順を一つずらして投稿します。\r\nリストの終端まで達した場合、最初のアカウントの状態を見て、規制されていればそこで" +
        "連鎖は中断されます。\r\n規制情報の表示と同様、やや重い動作です。");
			this.ChangeAcc.UseVisualStyleBackColor = true;
			this.ChangeAcc.Click += new System.EventHandler(this.ChangeAcc_CheckedChanged);
			// 
			// TextSave
			// 
			this.TextSave.AutoSize = true;
			this.TextSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextSave.Location = new System.Drawing.Point(87, 215);
			this.TextSave.Name = "TextSave";
			this.TextSave.Size = new System.Drawing.Size(380, 18);
			this.TextSave.TabIndex = 44;
			this.TextSave.Text = "投稿後に文章を削除せず保持する";
			this.toolTip1.SetToolTip(this.TextSave, "呟いた内容を呟き後に削除しないで、そのままにします。");
			this.TextSave.UseVisualStyleBackColor = true;
			this.TextSave.Click += new System.EventHandler(this.TextSave_CheckedChanged);
			// 
			// BackgroundColorEdit
			// 
			this.BackgroundColorEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackgroundColorEdit.Location = new System.Drawing.Point(365, 103);
			this.BackgroundColorEdit.Name = "BackgroundColorEdit";
			this.BackgroundColorEdit.Size = new System.Drawing.Size(102, 26);
			this.BackgroundColorEdit.TabIndex = 66;
			this.BackgroundColorEdit.Text = "色を指定";
			this.toolTip1.SetToolTip(this.BackgroundColorEdit, "投稿ウインドウ下部の色を指定します。");
			this.BackgroundColorEdit.UseVisualStyleBackColor = true;
			this.BackgroundColorEdit.Click += new System.EventHandler(this.BackgroundColorEdit_Click);
			// 
			// IsGradation
			// 
			this.IsGradation.AutoSize = true;
			this.tableLayoutPanel6.SetColumnSpan(this.IsGradation, 4);
			this.IsGradation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.IsGradation.Location = new System.Drawing.Point(111, 135);
			this.IsGradation.Name = "IsGradation";
			this.IsGradation.Size = new System.Drawing.Size(356, 18);
			this.IsGradation.TabIndex = 65;
			this.IsGradation.Text = "情報表示部分の背景色をグラデーションで描画する";
			this.toolTip1.SetToolTip(this.IsGradation, "背景色を白と選択色のグラデーションで表示します．");
			this.IsGradation.UseVisualStyleBackColor = true;
			this.IsGradation.Click += new System.EventHandler(this.IsGradation_CheckedChanged);
			// 
			// StringColorEdit
			// 
			this.StringColorEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StringColorEdit.Location = new System.Drawing.Point(365, 71);
			this.StringColorEdit.Name = "StringColorEdit";
			this.StringColorEdit.Size = new System.Drawing.Size(102, 26);
			this.StringColorEdit.TabIndex = 61;
			this.StringColorEdit.Text = "色を指定";
			this.toolTip1.SetToolTip(this.StringColorEdit, "投稿アカウントや残文字数などの表示の文字色を指定します。");
			this.StringColorEdit.UseVisualStyleBackColor = true;
			this.StringColorEdit.Click += new System.EventHandler(this.StringColorEdit_Click);
			// 
			// FontSetting
			// 
			this.FontSetting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FontSetting.Location = new System.Drawing.Point(365, 39);
			this.FontSetting.Name = "FontSetting";
			this.FontSetting.Size = new System.Drawing.Size(102, 26);
			this.FontSetting.TabIndex = 57;
			this.FontSetting.Text = "フォントを指定";
			this.toolTip1.SetToolTip(this.FontSetting, "フォントの設定を変更します。");
			this.FontSetting.UseVisualStyleBackColor = true;
			this.FontSetting.Click += new System.EventHandler(this.FontSetting_Click);
			// 
			// ShowPosition
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.ShowPosition, 2);
			this.ShowPosition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ShowPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ShowPosition.FormattingEnabled = true;
			this.ShowPosition.Items.AddRange(new object[] {
            "左下",
            "左上",
            "右下",
            "右上",
            "中央"});
			this.ShowPosition.Location = new System.Drawing.Point(119, 71);
			this.ShowPosition.Name = "ShowPosition";
			this.ShowPosition.Size = new System.Drawing.Size(348, 26);
			this.ShowPosition.TabIndex = 57;
			this.toolTip1.SetToolTip(this.ShowPosition, "起動時のウインドウの表示位置を指定します。");
			this.ShowPosition.Click += new System.EventHandler(this.ShowPosition_SelectedIndexChanged);
			// 
			// HideFormAfterTweet
			// 
			this.HideFormAfterTweet.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.HideFormAfterTweet, 2);
			this.HideFormAfterTweet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HideFormAfterTweet.Location = new System.Drawing.Point(119, 103);
			this.HideFormAfterTweet.Name = "HideFormAfterTweet";
			this.HideFormAfterTweet.Size = new System.Drawing.Size(348, 18);
			this.HideFormAfterTweet.TabIndex = 58;
			this.HideFormAfterTweet.Text = "投稿後フォームを自動で隠す";
			this.toolTip1.SetToolTip(this.HideFormAfterTweet, "ツイート後にウインドウを隠します。");
			this.HideFormAfterTweet.UseVisualStyleBackColor = true;
			this.HideFormAfterTweet.Click += new System.EventHandler(this.HideFormAfterTweet_CheckedChanged);
			// 
			// HideOffFocus
			// 
			this.HideOffFocus.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.HideOffFocus, 2);
			this.HideOffFocus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HideOffFocus.Location = new System.Drawing.Point(119, 151);
			this.HideOffFocus.Name = "HideOffFocus";
			this.HideOffFocus.Size = new System.Drawing.Size(348, 18);
			this.HideOffFocus.TabIndex = 59;
			this.HideOffFocus.Text = "残文字数などの文字情報欄を隠す";
			this.toolTip1.SetToolTip(this.HideOffFocus, "残文字数などの情報を隠します。");
			this.HideOffFocus.UseVisualStyleBackColor = true;
			this.HideOffFocus.Click += new System.EventHandler(this.HideOffFocus_CheckedChanged);
			// 
			// tabControl1
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.tabControl1, 4);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(484, 299);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(476, 221);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "アカウント設定";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
			this.tableLayoutPanel1.Controls.Add(this.AccountDelete, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.AccountAdd, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.PostUserAccount, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 215);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 30);
			this.label4.TabIndex = 1;
			this.label4.Text = "アカウント指定: ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel1.SetColumnSpan(this.label7, 4);
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.ForeColor = System.Drawing.SystemColors.Window;
			this.label7.Location = new System.Drawing.Point(3, 3);
			this.label7.Margin = new System.Windows.Forms.Padding(3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(464, 30);
			this.label7.TabIndex = 0;
			this.label7.Text = "アカウント関連の設定";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tableLayoutPanel2);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(476, 268);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "表示設定";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoScroll = true;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			this.tableLayoutPanel2.Controls.Add(this.IsIconShow, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.HideOffFocus, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.HideFormAfterTweet, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.ShowPosition, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.SettingKey, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.ShowHideKey, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label16, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 7;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 262);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 32);
			this.label8.TabIndex = 56;
			this.label8.Text = "初期表示位置: ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ShowHideKey
			// 
			this.ShowHideKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowHideKey.Location = new System.Drawing.Point(119, 39);
			this.ShowHideKey.Name = "ShowHideKey";
			this.ShowHideKey.ReadOnly = true;
			this.ShowHideKey.Size = new System.Drawing.Size(233, 25);
			this.ShowHideKey.TabIndex = 54;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 32);
			this.label5.TabIndex = 53;
			this.label5.Text = "表示/非表示キー: ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel2.SetColumnSpan(this.label16, 3);
			this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label16.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label16.ForeColor = System.Drawing.SystemColors.Window;
			this.label16.Location = new System.Drawing.Point(3, 3);
			this.label16.Margin = new System.Windows.Forms.Padding(3);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(464, 30);
			this.label16.TabIndex = 0;
			this.label16.Text = "表示関連の設定";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tableLayoutPanel6);
			this.tabPage3.Location = new System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(476, 268);
			this.tabPage3.TabIndex = 5;
			this.tabPage3.Text = "フォント/色設定";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 5;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
			this.tableLayoutPanel6.Controls.Add(this.BackgroundColorEdit, 4, 3);
			this.tableLayoutPanel6.Controls.Add(this.BackgroundColorText, 2, 3);
			this.tableLayoutPanel6.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel6.Controls.Add(this.BackgroundColorView, 1, 3);
			this.tableLayoutPanel6.Controls.Add(this.IsGradation, 1, 4);
			this.tableLayoutPanel6.Controls.Add(this.StringColorEdit, 4, 2);
			this.tableLayoutPanel6.Controls.Add(this.StringColorText, 2, 2);
			this.tableLayoutPanel6.Controls.Add(this.StringColorView, 1, 2);
			this.tableLayoutPanel6.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel6.Controls.Add(this.FontSetting, 4, 1);
			this.tableLayoutPanel6.Controls.Add(this.FontSize, 3, 1);
			this.tableLayoutPanel6.Controls.Add(this.FontName, 2, 1);
			this.tableLayoutPanel6.Controls.Add(this.FontColor, 1, 1);
			this.tableLayoutPanel6.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.label22, 0, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 6;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(470, 262);
			this.tableLayoutPanel6.TabIndex = 3;
			// 
			// BackgroundColorText
			// 
			this.BackgroundColorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel6.SetColumnSpan(this.BackgroundColorText, 2);
			this.BackgroundColorText.Location = new System.Drawing.Point(174, 103);
			this.BackgroundColorText.Name = "BackgroundColorText";
			this.BackgroundColorText.ReadOnly = true;
			this.BackgroundColorText.Size = new System.Drawing.Size(185, 25);
			this.BackgroundColorText.TabIndex = 64;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 32);
			this.label3.TabIndex = 62;
			this.label3.Text = "背景色: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BackgroundColorView
			// 
			this.BackgroundColorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BackgroundColorView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackgroundColorView.Location = new System.Drawing.Point(111, 103);
			this.BackgroundColorView.Name = "BackgroundColorView";
			this.BackgroundColorView.Size = new System.Drawing.Size(57, 26);
			this.BackgroundColorView.TabIndex = 63;
			// 
			// StringColorText
			// 
			this.StringColorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel6.SetColumnSpan(this.StringColorText, 2);
			this.StringColorText.Location = new System.Drawing.Point(174, 71);
			this.StringColorText.Name = "StringColorText";
			this.StringColorText.ReadOnly = true;
			this.StringColorText.Size = new System.Drawing.Size(185, 25);
			this.StringColorText.TabIndex = 60;
			// 
			// StringColorView
			// 
			this.StringColorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StringColorView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StringColorView.Location = new System.Drawing.Point(111, 71);
			this.StringColorView.Name = "StringColorView";
			this.StringColorView.Size = new System.Drawing.Size(57, 26);
			this.StringColorView.TabIndex = 59;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 32);
			this.label2.TabIndex = 58;
			this.label2.Text = "情報表示文字色: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FontSize
			// 
			this.FontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FontSize.Location = new System.Drawing.Point(310, 39);
			this.FontSize.Name = "FontSize";
			this.FontSize.ReadOnly = true;
			this.FontSize.Size = new System.Drawing.Size(49, 25);
			this.FontSize.TabIndex = 56;
			this.FontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// FontName
			// 
			this.FontName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FontName.Location = new System.Drawing.Point(174, 39);
			this.FontName.Name = "FontName";
			this.FontName.ReadOnly = true;
			this.FontName.Size = new System.Drawing.Size(130, 25);
			this.FontName.TabIndex = 55;
			// 
			// FontColor
			// 
			this.FontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FontColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FontColor.Location = new System.Drawing.Point(111, 39);
			this.FontColor.Name = "FontColor";
			this.FontColor.Size = new System.Drawing.Size(57, 26);
			this.FontColor.TabIndex = 54;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 32);
			this.label1.TabIndex = 53;
			this.label1.Text = "フォント設定: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel6.SetColumnSpan(this.label22, 5);
			this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label22.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label22.ForeColor = System.Drawing.SystemColors.Window;
			this.label22.Location = new System.Drawing.Point(3, 3);
			this.label22.Margin = new System.Windows.Forms.Padding(3);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(464, 30);
			this.label22.TabIndex = 0;
			this.label22.Text = "フォント / 色関連の設定";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.tableLayoutPanel4);
			this.tabPage4.Location = new System.Drawing.Point(4, 27);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(476, 268);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "投稿設定";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.SplitInsertNext, 1, 6);
			this.tableLayoutPanel4.Controls.Add(this.SplitAtPoint, 1, 5);
			this.tableLayoutPanel4.Controls.Add(this.AutoTextSplit, 1, 4);
			this.tableLayoutPanel4.Controls.Add(this.ChangeAcc, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.TextSave, 1, 8);
			this.tableLayoutPanel4.Controls.Add(this.ShowRegulationInfo, 1, 2);
			this.tableLayoutPanel4.Controls.Add(this.RentouKaihi, 1, 7);
			this.tableLayoutPanel4.Controls.Add(this.PostKey, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 10;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(470, 262);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 32);
			this.label6.TabIndex = 39;
			this.label6.Text = "投稿キー: ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel4.SetColumnSpan(this.label10, 2);
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label10.ForeColor = System.Drawing.SystemColors.Window;
			this.label10.Location = new System.Drawing.Point(3, 3);
			this.label10.Margin = new System.Windows.Forms.Padding(3);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(464, 30);
			this.label10.TabIndex = 0;
			this.label10.Text = "投稿関連の設定";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.tableLayoutPanel5);
			this.tabPage5.Location = new System.Drawing.Point(4, 27);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(476, 268);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "情報";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.ApplicationVersion, 1, 2);
			this.tableLayoutPanel5.Controls.Add(this.label15, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.linkLabel3, 1, 5);
			this.tableLayoutPanel5.Controls.Add(this.linkLabel2, 1, 4);
			this.tableLayoutPanel5.Controls.Add(this.label14, 1, 1);
			this.tableLayoutPanel5.Controls.Add(this.label13, 0, 3);
			this.tableLayoutPanel5.Controls.Add(this.label12, 0, 4);
			this.tableLayoutPanel5.Controls.Add(this.label11, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.linkLabel1, 1, 3);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 7;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(470, 262);
			this.tableLayoutPanel5.TabIndex = 3;
			// 
			// ApplicationVersion
			// 
			this.ApplicationVersion.AutoSize = true;
			this.ApplicationVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ApplicationVersion.Location = new System.Drawing.Point(93, 60);
			this.ApplicationVersion.Name = "ApplicationVersion";
			this.ApplicationVersion.Size = new System.Drawing.Size(374, 24);
			this.ApplicationVersion.TabIndex = 9;
			this.ApplicationVersion.Text = "#APPLICATION_VERSION";
			this.ApplicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label15.Location = new System.Drawing.Point(3, 60);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(84, 24);
			this.label15.TabIndex = 8;
			this.label15.Text = "Version:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabel3.Location = new System.Drawing.Point(93, 132);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(374, 24);
			this.linkLabel3.TabIndex = 7;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Github";
			this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabel2.Location = new System.Drawing.Point(93, 108);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(374, 24);
			this.linkLabel2.TabIndex = 6;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Official Site";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label14.Location = new System.Drawing.Point(93, 36);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(374, 24);
			this.label14.TabIndex = 4;
			this.label14.Text = "TwiField";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Location = new System.Drawing.Point(3, 84);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(84, 24);
			this.label13.TabIndex = 3;
			this.label13.Text = "Auther:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Location = new System.Drawing.Point(3, 108);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(84, 24);
			this.label12.TabIndex = 2;
			this.label12.Text = "Site:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel5.SetColumnSpan(this.label11, 2);
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label11.ForeColor = System.Drawing.SystemColors.Window;
			this.label11.Location = new System.Drawing.Point(3, 3);
			this.label11.Margin = new System.Windows.Forms.Padding(3);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(464, 30);
			this.label11.TabIndex = 0;
			this.label11.Text = "Application Information";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 36);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(84, 24);
			this.label9.TabIndex = 1;
			this.label9.Text = "Name:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabel1.Location = new System.Drawing.Point(93, 84);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(374, 24);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Arika (Delete0093@Gmail.com)";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
			this.tableLayoutPanel3.Controls.Add(this.TfExit, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.Cancel, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.OK, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.tabControl1, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(490, 344);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// AutoTextSplit
			// 
			this.AutoTextSplit.AutoSize = true;
			this.AutoTextSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AutoTextSplit.Location = new System.Drawing.Point(87, 119);
			this.AutoTextSplit.Name = "AutoTextSplit";
			this.AutoTextSplit.Size = new System.Drawing.Size(380, 18);
			this.AutoTextSplit.TabIndex = 45;
			this.AutoTextSplit.Text = "文字数制限を超過した際に自動で文章を区切る";
			this.toolTip1.SetToolTip(this.AutoTextSplit, "Twitterの文字数制限である140文字を超過した内容を投稿する際に自動で文字列を分割します．");
			this.AutoTextSplit.UseVisualStyleBackColor = true;
			this.AutoTextSplit.CheckedChanged += new System.EventHandler(this.AutoTextSplit_CheckedChanged);
			// 
			// SplitAtPoint
			// 
			this.SplitAtPoint.AutoSize = true;
			this.SplitAtPoint.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitAtPoint.Location = new System.Drawing.Point(87, 143);
			this.SplitAtPoint.Name = "SplitAtPoint";
			this.SplitAtPoint.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.SplitAtPoint.Size = new System.Drawing.Size(380, 18);
			this.SplitAtPoint.TabIndex = 46;
			this.SplitAtPoint.Text = "句読点や空白，改行部分でのみ区切る(推奨)";
			this.toolTip1.SetToolTip(this.SplitAtPoint, "文章の途中でむりやり区切らずに，句読点や空白などの\r\n区切っても意味が通用する部分でのみ区切ります．");
			this.SplitAtPoint.UseVisualStyleBackColor = true;
			this.SplitAtPoint.CheckedChanged += new System.EventHandler(this.SplitAtPoint_CheckedChanged);
			// 
			// SplitInsertNext
			// 
			this.SplitInsertNext.AutoSize = true;
			this.SplitInsertNext.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitInsertNext.Location = new System.Drawing.Point(87, 167);
			this.SplitInsertNext.Name = "SplitInsertNext";
			this.SplitInsertNext.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.SplitInsertNext.Size = new System.Drawing.Size(380, 18);
			this.SplitInsertNext.TabIndex = 47;
			this.SplitInsertNext.Text = "文章の切れ目に(続く)を挿入する";
			this.toolTip1.SetToolTip(this.SplitInsertNext, "文章が切れた部分に[続く]の文字を挿入し，ツイートが連続しているものであることを表示します．");
			this.SplitInsertNext.UseVisualStyleBackColor = true;
			this.SplitInsertNext.CheckedChanged += new System.EventHandler(this.SplitInsertNext_CheckedChanged);
			// 
			// IsIconShow
			// 
			this.IsIconShow.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.IsIconShow, 2);
			this.IsIconShow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.IsIconShow.Location = new System.Drawing.Point(119, 127);
			this.IsIconShow.Name = "IsIconShow";
			this.IsIconShow.Size = new System.Drawing.Size(348, 18);
			this.IsIconShow.TabIndex = 60;
			this.IsIconShow.Text = "アイコンを表示する";
			this.toolTip1.SetToolTip(this.IsIconShow, "投稿BOXの横にアイコンを表示するかどうかを指定します．");
			this.IsIconShow.UseVisualStyleBackColor = true;
			this.IsIconShow.CheckedChanged += new System.EventHandler(this.IsIconShow_CheckedChanged);
			// 
			// Setting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(490, 344);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Setting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TwiField Application Setting";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
			this.Load += new System.EventHandler(this.Setting_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button TfExit;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button AccountDelete;
		private System.Windows.Forms.Button AccountAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox PostUserAccount;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button SettingKey;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.CheckBox ChangeAcc;
		private System.Windows.Forms.CheckBox TextSave;
		private System.Windows.Forms.CheckBox ShowRegulationInfo;
		private System.Windows.Forms.CheckBox RentouKaihi;
		private System.Windows.Forms.ComboBox PostKey;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label ApplicationVersion;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Button BackgroundColorEdit;
		private System.Windows.Forms.TextBox BackgroundColorText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel BackgroundColorView;
		private System.Windows.Forms.CheckBox IsGradation;
		private System.Windows.Forms.Button StringColorEdit;
		private System.Windows.Forms.TextBox StringColorText;
		private System.Windows.Forms.Panel StringColorView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button FontSetting;
		private System.Windows.Forms.TextBox FontSize;
		private System.Windows.Forms.TextBox FontName;
		private System.Windows.Forms.Panel FontColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.CheckBox HideOffFocus;
		private System.Windows.Forms.CheckBox HideFormAfterTweet;
		private System.Windows.Forms.ComboBox ShowPosition;
		private System.Windows.Forms.TextBox ShowHideKey;
		private System.Windows.Forms.CheckBox SplitInsertNext;
		private System.Windows.Forms.CheckBox SplitAtPoint;
		private System.Windows.Forms.CheckBox AutoTextSplit;
		private System.Windows.Forms.CheckBox IsIconShow;
	}
}