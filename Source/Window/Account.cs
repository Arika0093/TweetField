﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using TweetSharp;

namespace TweetField
{
	public partial class Account : Form
	{
		// User Data
		private TwAccount AccUser = new TwAccount();
		// Add Account Flag
		private bool AddAcc = false;
		// TwitterService 
		private TwitterService TwiServ;
		// Request Token
		private OAuthRequestToken reqToken;

		// Get Account Data
		public TwAccount OAuthCheck(Form ParentWindow)
		{
			// Show 
			ShowDialog(ParentWindow);
			// return State
			return ( AddAcc ? AccUser : null );
		}

		// Constructor
		public Account()
		{
			// Init
			InitializeComponent();
			// Item Add
			foreach(var Consumer in ConsumerList.ConsLists){
				if((Keyboard.IsKeyDown(Key.ImeConvert) &&
					Keyboard.IsKeyDown(Key.ImeNonConvert)) ||
					Consumer.HiddenItem == false){
						ConsumersList.Items.Add(Consumer.Name);
				}
			}
			// Select This
			ConsumersList.SelectedIndex = 0;
		}

		// Check on Browser
		private void StartOAuth_Click(object sender, EventArgs e)
		{
			// if Only Key or Secret Input
			if ((ConsKey.Text.Length == 0 || ConsSecret.Text.Length == 0) && ConsKey.Enabled){
				// Show Error Message
				MessageBox.Show("KeyまたはSecretが未入力です。");
				// End
				return;
			}
			// Key Setting Check
			AccUser.ConsKey = (ConsKey.Text.Length == 0 ?
				ConsumerList.ConsLists[ConsumersList.SelectedIndex].Key : ConsKey.Text);
			AccUser.ConsSecret = (ConsKey.Text.Length == 0 ?
				ConsumerList.ConsLists[ConsumersList.SelectedIndex].Secret : ConsSecret.Text);
			// Create Service Instance
			TwiServ = new TwitterService(AccUser.ConsKey, AccUser.ConsSecret);
			// Create Access Token
			reqToken = TwiServ.GetRequestToken();
			// Get Uri
			Uri uri = TwiServ.GetAuthenticationUrl(reqToken);
			// Open Browse
			new Browser(uri.ToString()).Show();
			// Enable Change
			PINEdit.Enabled = true;
		}

		// PINEDit Text Change 
		private void PINEdit_TextChanged(object sender, EventArgs e)
		{
			// Change Button Enable State
			AddAccount.Enabled =
			FollowAuther.Enabled = ShowName.Enabled = ( PINEdit.Text.Length != 0 );
		}

		// Add Account
		private void AddAccount_Click(object sender, EventArgs e)
		{
			// Get Access Token Instance
			OAuthAccessToken Access = TwiServ.GetAccessToken(reqToken, PINEdit.Text);
			// OAuth
			TwiServ.AuthenticateWith(Access.Token, Access.TokenSecret);
			// if Follow Auther
			if(FollowAuther.Checked){
				// Create Option Instance
				FollowUserOptions FollowOpt = new FollowUserOptions();
				// Set User
				FollowOpt.ScreenName = "@arik_a_";
				// Try (for Error)
				try{
					// Follow
					TwiServ.FollowUser(FollowOpt);
				}
				// Catch
				catch( Exception ){
					// No Doing
				}
			}
			// Account Setting
			AccUser.UserName		= TwiServ.GetAccountSettings().ScreenName;
			AccUser.ShowName		= (ShowName.Text.Length != 0 ? ShowName.Text :
										TwiServ.GetUserProfileFor(new GetUserProfileForOptions{
											ScreenName = TwiServ.GetAccountSettings().ScreenName
										}).Name);
			AccUser.AccessToken		= Access.Token;
			AccUser.AccessSecret	= Access.TokenSecret;
			// Add Flag ON
			AddAcc = true;
			// Close
			Close();
		}

		// Select Change
		private void ConsumersList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConsKey.Enabled =
			ConsSecret.Enabled = (ConsumersList.SelectedIndex == ConsumersList.Items.Count-1);

		}
	}
}
