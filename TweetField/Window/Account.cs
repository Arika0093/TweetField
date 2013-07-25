using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
		}

		// Check on Browser
		private void StartOAuth_Click(object sender, EventArgs e)
		{
			// if Only Key or Secret Input
			if ((ConsKey.Text.Length == 0 && ConsSecret.Text.Length != 0)
			|| (ConsKey.Text.Length != 0 && ConsSecret.Text.Length == 0))
			{
				// Show Error Message
				MessageBox.Show("KeyまたはSecret Keyのどちらかが未入力です。");
				// End
				return;
			}
			// Key Setting Check
			AccUser.ConsKey = (ConsKey.Text.Length == 0 ? ConsumerValue.Key : ConsKey.Text);
			AccUser.ConsSecret = (ConsKey.Text.Length == 0 ? ConsumerValue.Secret : ConsSecret.Text);
			// Create Service Instance
			TwiServ = new TwitterService(AccUser.ConsKey, AccUser.ConsSecret);
			// Create Access Token
			reqToken = TwiServ.GetRequestToken();
			// Get Uri
			Uri uri = TwiServ.GetAuthenticationUrl(reqToken);
			// Open Browse
			System.Diagnostics.Process.Start(uri.ToString());
			// Enable Change
			PINEdit.Enabled = true;
		}

		// PINEDit Text Change 
		private void PINEdit_TextChanged(object sender, EventArgs e)
		{
			// Change Button Enable State
			AddAccount.Enabled = ( PINEdit.Text.Length != 0 );
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
				FollowOpt.ScreenName = "@Arika0093";
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
			AccUser.AccessToken		= Access.Token;
			AccUser.AccessSecret	= Access.TokenSecret;
			// Add Flag ON
			AddAcc = true;
			// Close
			Close();
		}
	}
}
