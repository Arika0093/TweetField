using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TweetField
{
	public partial class Setting : Form
	{
		// Setting Data
		ApplicationSetting ApSetting;

		// Constructor
		public Setting(ApplicationSetting aps)
		{
			// Reset
			InitializeComponent();
			// Copy
			ApSetting = aps;
		}

		public ApplicationSetting SettingChange(Form Parent)
		{
			// Show
			ShowDialog(Parent);
			// Return
			return (DialogResult == DialogResult.OK ? AppSettingAccess.LoadSetting() : null);
		}

		// Some Setting Reload
		private void SettingReload()
		{
			// Color Convertor
			ColorConverter ClConv = new ColorConverter();
			// ---------------------------------------------------
			// List Clear
			PostUserAccount.Items.Clear();
			// Account Add
			if(ApSetting.TwitterAccs != null)
			{
				foreach( TwAccount Acc in ApSetting.TwitterAccs )
				{
					PostUserAccount.Items.Add(Acc.ShowName + " [@" + Acc.UserName + "]");
				}
			}
			// Account Setting
			PostUserAccount.SelectedIndex	= ApSetting.UsingAccountVal;
			FontColor.BackColor				= (Color)ClConv.ConvertFromString(ApSetting.FontColor);
			FontName.Text					= ApSetting.SysFontName;
			FontSize.Text					= ApSetting.SysFontSize.ToString();
			BackgroundColorView.BackColor	= (Color)ClConv.ConvertFromString(ApSetting.FooterColor);
			BackgroundColorText.Text		= ApSetting.FooterColor;
			StringColorView.BackColor		= (Color)ClConv.ConvertFromString(ApSetting.StringColor);
			StringColorText.Text			= ApSetting.StringColor;
			ShowHideKey.Text				= HotKey.GetKeyString(ApSetting.ShowKeyChar, ApSetting.ShowModKey);
			ShowPosition.SelectedIndex		= ApSetting.ShowWindowPosition;
			PostKey.SelectedIndex			= ApSetting.PostKeyType;
			RentouKaihi.Checked				= ApSetting.DualPost;
			TextSave.Checked				= ApSetting.NoResetString;
			HideOffFocus.Checked			= ApSetting.HideInformation;
			HideFormAfterTweet.Checked		= ApSetting.HideTweetWindow;
			ShowRegulationInfo.Checked		= ApSetting.RegulationInfoShow;
			ChangeAcc.Checked				= ApSetting.ChangeAccOnRegulation;
			IsGradation.Checked				= ApSetting.Gradation;
			IsIconShow.Checked				= ApSetting.IconShowed;
			AutoTextSplit.Checked			= ApSetting.SplitText;
			SplitAtPoint.Checked			= ApSetting.SplitAtSpace;
			SplitInsertNext.Checked			= ApSetting.SplitInsert_NEXT;
			AtUserSuggest.Checked			= ApSetting.UserSuggestUsed;
			IsUsePicture.Checked			= ApSetting.LoadPictureAtSuggest;
			// Enable Change
			ChangeAcc.Enabled				= ApSetting.RegulationInfoShow;
			SplitAtPoint.Enabled			= ApSetting.SplitText;
			SplitInsertNext.Enabled			= ApSetting.SplitText;
			IsUsePicture.Enabled			= ApSetting.UserSuggestUsed;
			AccountDelete.Enabled			= ( ApSetting.UsingAccountVal != -1 );
			OK.Enabled						= ( ApSetting.UsingAccountVal != -1 );
		}

		// Call On Load
		private void Setting_Load(object sender, EventArgs e)
		{
			// Setting Load
			SettingReload();
			// Autorun Registry Check
			AutoRun.Checked = Registry.CurrentUser.OpenSubKey(
				@"Software\Microsoft\Windows\CurrentVersion\Run", true)
				.GetValue(Application.ProductName) != null;
			// Get own Assembly
			System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
			// Get Version
			Version Ver = asm.GetName().Version;
			// Set
			ApplicationVersion.Text = Ver.ToString();
		}

		// Account Select
		private void PostUserAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Account Select Change
			ApSetting.UsingAccountVal = PostUserAccount.SelectedIndex;
			// Enable Change
			OK.Enabled =
			AccountDelete.Enabled = (ApSetting.UsingAccountVal != -1);
		}

		// Add Account
		private void AccountAdd_Click(object sender, EventArgs e)
		{
			// Create Instance
			Account acWindow = new Account();
			// -------------------------------------------
			// Account Get
			TwAccount NewTwitAc = acWindow.OAuthCheck(this);
			// if it is not null
			if(NewTwitAc != null){
				// Add List
				ApSetting.TwitterAccs.Add(NewTwitAc);
				// Reload
				SettingReload();
				// Select Change
				PostUserAccount.SelectedIndex = ApSetting.TwitterAccs.Count - 1;
				// Reload
				SettingReload();
			}
		}

		// Delete Account
		private void AccountDelete_Click(object sender, EventArgs e)
		{
			// Warning Message
			if(MessageBox.Show("選択中のアカウントを削除します．この動作は元に戻せません．よろしいですか？", "警告",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK){
				return;
			}
			// Remove
			ApSetting.TwitterAccs.RemoveAt(PostUserAccount.SelectedIndex);
			// Selected -1
			ApSetting.UsingAccountVal--;
			// Reload
			SettingReload();
		}

		// Show Font Setting Form
		private void FontSetting_Click(object sender, EventArgs e)
		{
			// Create instance
			FontDialog fd	= new FontDialog();
			// Color Convertor
			ColorConverter ClConv = new ColorConverter();
			// ---------------------------------------------------
			// Member Reset
			fd.Font			= new Font(FontName.Text, float.Parse(FontSize.Text));
			fd.Color		= (Color)ClConv.ConvertFromString(ApSetting.FontColor);		
			fd.ShowColor	= true;
			fd.ScriptsOnly	= false;
			fd.AllowVerticalFonts	= false;
			// Show
			if(fd.ShowDialog() == DialogResult.OK){
				// Exchange
				ApSetting.SysFontName	= fd.Font.Name;
				ApSetting.SysFontSize	= fd.Font.Size;
				ApSetting.FontColor		= ClConv.ConvertToString(fd.Color);
				// Reload
				SettingReload();
			}
		}

		// Background Color Edit
		private void BackgroundColorEdit_Click(object sender, EventArgs e)
		{
			// Create Instance
			var ColorDlg = new ColorSelect();
			// ---------------------------------------------------
			ColorDlg.ColorStr = ApSetting.FooterColor;
			// Show Dialog
			if(ColorDlg.ShowDialog() == DialogResult.OK){
				// Set Color
				ApSetting.FooterColor = ColorDlg.ColorStr;
				// Reload
				SettingReload();
			}
		}

		// String Color Edit
		private void StringColorEdit_Click(object sender, EventArgs e)
		{
			// Create Instance
			var ColorDlg = new ColorSelect();
			// ---------------------------------------------------
			ColorDlg.ColorStr = ApSetting.StringColor;
			// Show Dialog
			if(ColorDlg.ShowDialog() == DialogResult.OK){
				// Set Color
				ApSetting.StringColor = ColorDlg.ColorStr;
				// Reload
				SettingReload();
			}
		}

		// Setting Hot Key
		private void SettingKey_Click(object sender, EventArgs e)
		{
			// Create
			HotKeyEdit hkEdit = new HotKeyEdit();
			// -------------------------
			// Get
			String Result = hkEdit.SetHotKey(ref ApSetting.ShowKeyChar, ref ApSetting.ShowModKey, this);
			// Set
			if(Result.Length > 0){ ShowHideKey.Text = Result; }
		}

		// Position Changed
		private void ShowPosition_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.ShowWindowPosition = ShowPosition.SelectedIndex;
		}

		// Post Key Changed
		private void PostKey_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.PostKeyType = PostKey.SelectedIndex;
		}

		// API Set
		private void APISetting_Click(object sender, EventArgs e)
		{
			// Show Dialog
			new TranslatorSet(ref ApSetting).ShowDialog();
			// Reload
			SettingReload();
		}

		// Rentou Kaihi
		private void RentouKaihi_CheckedChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.DualPost = RentouKaihi.Checked;
		}

		// Text Save
		private void TextSave_CheckedChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.NoResetString = TextSave.Checked;
		}

		// Hide Off focus
		private void HideOffFocus_CheckedChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.HideInformation = HideOffFocus.Checked;
		}

		// Hide after Tweet
		private void HideFormAfterTweet_CheckedChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.HideTweetWindow = HideFormAfterTweet.Checked;
		}

		// ShowRegulationInfo_Checked
		private void ShowRegulationInfo_CheckedChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.RegulationInfoShow	= ShowRegulationInfo.Checked;
			// If Regulation isnot used
			if(!ApSetting.RegulationInfoShow){
				// Change Account is not 
				ApSetting.ChangeAccOnRegulation = false;
			}
			// Reload
			SettingReload();
		}

		// ChangeAcc_Checked
		private void ChangeAcc_CheckedChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.ChangeAccOnRegulation = ChangeAcc.Checked;
		}

		// Gradation
		private void IsGradation_CheckedChanged(object sender, EventArgs e)
		{
			// Setting Change
			ApSetting.Gradation = IsGradation.Checked;
		}

		// Icon Showed
		private void IsIconShow_CheckedChanged(object sender, EventArgs e)
		{
			ApSetting.IconShowed = IsIconShow.Checked;
		}

		// Split Text
		private void AutoTextSplit_CheckedChanged(object sender, EventArgs e)
		{
			ApSetting.SplitText = AutoTextSplit.Checked;
			// Reload
			SettingReload();
		}

		// Split at space
		private void SplitAtPoint_CheckedChanged(object sender, EventArgs e)
		{
			ApSetting.SplitAtSpace = SplitAtPoint.Checked;
		}

		// Split Insert Next
		private void SplitInsertNext_CheckedChanged(object sender, EventArgs e)
		{
			ApSetting.SplitInsert_NEXT = SplitInsertNext.Checked;
		}
		
		// Autorun setting changed
		private void AutoRun_CheckedChanged(object sender, EventArgs e)
		{
			var key = Registry.CurrentUser.CreateSubKey(
				@"Software\Microsoft\Windows\CurrentVersion\Run");
			// if true, setting
			if(AutoRun.Checked == true){
				key.SetValue(Application.ProductName, Application.ExecutablePath);
			}
			// else, delete key
			else{
				key.DeleteValue(Application.ProductName);
			}
		}

		// UserSuggest changed
		private void AtUserSuggest_CheckedChanged(object sender, EventArgs e)
		{
			ApSetting.UserSuggestUsed = AtUserSuggest.Checked;
			// Reload
			SettingReload();
		}

		// Use Picture
		private void IsUsePicture_CheckedChanged(object sender, EventArgs e)
		{
			ApSetting.LoadPictureAtSuggest = IsUsePicture.Checked;
		}

		// Setting Save
		private void OK_Click(object sender, EventArgs e)
		{
			// Save
			AppSettingAccess.SaveSetting(ApSetting);
			// Result OK
			DialogResult = DialogResult.OK;
			// Close
			Close();
		}

		// Setting Cancel
		private void Cancel_Click(object sender, EventArgs e)
		{
			// Result Cancel
			DialogResult = DialogResult.Cancel;
			Close();
		}

		// Application Exit
		private void TfExit_Click(object sender, EventArgs e)
		{
			// Result is Abort
			DialogResult = DialogResult.Abort;
			// Close
			Close();
			// Program End
			Application.Exit();
		}

		// Form Closed
		private void Setting_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(ApSetting.UsingAccountVal < 0){
				// End
				Application.Exit();
			}
		}

		// Mail to Auther
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Open Mail Address
			System.Diagnostics.Process.Start("mailto:Delete0093@Gmail.com");
		}

		// Access to Official Site
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Open Site
			new Browser("http://practice.sarashi.com/pages/TwiField/TwiField.html").Show();
		}

		// Access to Github
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Open Github
			new Browser("https://github.com/Arika0093/TweetField").Show();
		}
	}
}
