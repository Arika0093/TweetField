﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
			return AppSettingAccess.LoadSetting();
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
					PostUserAccount.Items.Add(Acc.UserName);
				}
			}
			// Account Setting
			PostUserAccount.SelectedIndex	= ApSetting.UsingAccountVal;
			// Setting Item
			FontName.Text					= ApSetting.SysFontName;
			FontSize.Text					= ApSetting.SysFontSize.ToString();
			BackgrouondColorView.BackColor	= (Color)ClConv.ConvertFromString(ApSetting.FooterColor);
			BackgroundColorText.Text		= ApSetting.FooterColor;
			StringColorView.BackColor		= (Color)ClConv.ConvertFromString(ApSetting.StringColor);
			StringColorText.Text			= ApSetting.StringColor;
			ShowHideKey.Text				= HotKey.GetKeyString(ApSetting.ShowKeyChar, ApSetting.ShowModKey);
			ShowPosition.SelectedIndex		= ApSetting.ShowWindowPosition;
			PostKey.SelectedIndex			= ApSetting.PostKeyType;
			HideOffFocus.Checked			= ApSetting.HideInformation;
			HideFormAfterTweet.Checked		= ApSetting.HideTweetWindow;
			// Enable Change
			AccountDelete.Enabled			= ( ApSetting.UsingAccountVal != -1 );
			OK.Enabled						= ( ApSetting.UsingAccountVal != -1 );
		}

		// Call On Load
		private void Setting_Load(object sender, EventArgs e)
		{
			SettingReload();
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
			// ---------------------------------------------------
			// Member Reset
			fd.Font			= new Font(FontName.Text, float.Parse(FontSize.Text));
			fd.ScriptsOnly	= false;
			fd.ShowEffects	= false;
			fd.AllowVerticalFonts	= false;
			// Show
			if(fd.ShowDialog() == DialogResult.OK){
				// Exchange
				ApSetting.SysFontName = fd.Font.Name;
				ApSetting.SysFontSize = fd.Font.Size;
				// Reload
				SettingReload();
			}
		}

		// Background Color Edit
		private void BackgroundColorEdit_Click(object sender, EventArgs e)
		{
			// Create Instance
			ColorDialog ColorDlg = new ColorDialog();
			// Color Convertor
			ColorConverter ClConv = new ColorConverter();
			// ---------------------------------------------------
			// Set Defualt Data
			ColorDlg.Color			= BackgrouondColorView.BackColor;
			ColorDlg.FullOpen		= true;
			// Show Dialog
			if(ColorDlg.ShowDialog() == DialogResult.OK){
				// Set Color
				ApSetting.FooterColor = ClConv.ConvertToString(ColorDlg.Color);
				// Reload
				SettingReload();
			}
		}

		// String Color Edit
		private void StringColorEdit_Click(object sender, EventArgs e)
		{
			// Create Instance
			ColorDialog ColorDlg = new ColorDialog();
			// Color Convertor
			ColorConverter ClConv = new ColorConverter();
			// ---------------------------------------------------
			// Set Defualt Data
			ColorDlg.Color = StringColorView.BackColor;
			ColorDlg.FullOpen = true;
			// Show Dialog
			if (ColorDlg.ShowDialog() == DialogResult.OK)
			{
				// Set Color
				ApSetting.StringColor = ClConv.ConvertToString(ColorDlg.Color);
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

		// Setting Save
		private void OK_Click(object sender, EventArgs e)
		{
			// Save
			AppSettingAccess.SaveSetting(ApSetting);
			// Close
			Close();
		}

		// Setting Cancel
		private void Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Application Exit
		private void TfExit_Click(object sender, EventArgs e)
		{
			Close();
			// Program End
			Application.Exit();
		}
	}
}