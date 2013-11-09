using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using TweetSharp;

namespace TweetField
{
	public partial class Post : Form
	{
		// Constructor
		public Post()
		{
			// Hide
			this.Hide();
			// Load
			AppStg = AppSettingAccess.LoadSetting();
			// if Account Value is 0
			if (AppStg.UsingAccountVal < 0)
			{
				// Create Instance
				var stWindow = new Setting(AppStg);
				// Setting Change
				AppStg = stWindow.SettingChange(this);
			}
			// Reset
			InitializeComponent();
			// Create Instance
			FormResizer	= new FormDragResizer(this, FormDragResizer.ResizeDirection.All, 8);
			FormMover	= new FormDragMover(this, 8);
			// Add Event
			FormResizer.AddMouseEvent(PostText);
			FormResizer.AddMouseEvent(pictureBox1);
			FormMover.AddEventHandler(PostText);
			FormMover.AddEventHandler(pictureBox1);
			// Set HotKey
			MOD_KEY ModKey = (MOD_KEY)Enum.ToObject(typeof(MOD_KEY), AppStg.ShowModKey);
			PostShow = new HotKey(ModKey, AppStg.ShowKeyChar);
			// Event Add
			PostShow.HotKeyPush += new EventHandler(HotPush);
		}

		// First Load
		private void Post_Load(object sender, EventArgs e)
		{
			// Color Convertor
			ColorConverter ClConv = new ColorConverter();
			// ---------------------------------------------------
			// Get Kisei
			if (AppStg.KiseiInfoShow) { GetKiseiNum(AppStg.TwitterAccs[AppStg.UsingAccountVal]); }
			// Exchange Font
			this.Font = new Font(AppStg.SysFontName, AppStg.SysFontSize);
			// Set Size
			Size = AppStg.WindowSize;
			// Show Position Change( X )
			switch(AppStg.ShowWindowPosition){
				case 2:		// ( Right Down )
				case 3:		// ( Right Up )
					// Change X Position
					Left = ( Screen.GetWorkingArea(this).Width - Width );
					break;
				case 4:		// ( Center )
					// Change X Position( Harf )
					Left = ( Screen.GetWorkingArea(this).Width - Width ) / 2;
					break;
				default:	// ( Other )
					Left = 0;
					break;
			}
			// Show Position Change( Y )
			switch(AppStg.ShowWindowPosition){
				case 0:		// ( Left Down )
				case 2:		// ( Right Down )
					// Change Y Position
					Top = ( Screen.GetWorkingArea(this).Height - Height);
					break;
				case 4:		// ( Center )
					// Change Y Position( Harf )
					Top = ( Screen.GetWorkingArea(this).Height - Height) / 2;
					break;
				default:	// ( Other )
					Top = 0;
					break;
			}
			// ShortCut Post Key String
			String PostKey = "";
			// ShortCut Post Key String Get
			switch(AppStg.PostKeyType){
				case 0:
					PostKey = "Enter";
					break;
				case 1:
					PostKey = "Ctrl + Enter";
					break;
				case 2:
					PostKey = "Shift + Enter";
					break;
				case 3:
					PostKey = "Alt + Enter";
					break;
			}
			// Set Default String
			DefTextString = "この欄に呟く内容を入力します。右クリックでメニューを表示します。\r\n"
				+ PostKey + "キーを押すことで呟きを投稿します。";
			// Image Set
			PostText.ForeColor = (Color)ClConv.ConvertFromString(AppStg.FontColor);
			// Active
			Activate();
			ActiveControl = PostText;
		}

		// Push Post Key
		private void PostText_KeyDown(object sender, KeyEventArgs e)
		{
			// Push Check
			if(	( e.KeyCode == Keys.Enter )								// Push Enter Key
			&&(	( AppStg.PostKeyType == 0 && e.KeyData == Keys.Enter)	// Push Enter Only
			||	( AppStg.PostKeyType == 1 && e.Control  )				// Push Control Key(Setting: 1)
			||	( AppStg.PostKeyType == 2 && e.Shift  )					// Push Shift Key(Setting: 2)
			||	( AppStg.PostKeyType == 3 && e.Alt  )) )				// Push Alt Key(Setting: 3)
			{
				// Post Text Tweet
				bool Result = TweetPost(PostText.Text);
				// if Result is false
				if(Result == false){
					// Not Do Default Key Function
					e.SuppressKeyPress = false;
					// end
					return;
				}
				// Kisei Check
				GetKiseiNum(AppStg.TwitterAccs[AppStg.UsingAccountVal], true);
				// Not Do Default Key Function
				e.SuppressKeyPress = true;
			}
			// If Push Escape Key
			if(e.KeyCode == Keys.Escape){
				// Form Close
				Hide();
			}
		}

		// On Focus
		private void PostText_Enter(object sender, EventArgs e)
		{
			// text = default
			if(PostText.Text == DefTextString)
			{
				PostText.ForeColor	= SystemColors.WindowText;
				PostText.Text		= "";
			}
		}

		// Out Focus
		private void PostText_Leave(object sender, EventArgs e)
		{
			// text = empty
			if (PostText.Text == "")
			{
				PostText.ForeColor	= SystemColors.ControlDark;
				PostText.Text		= DefTextString;
			}
		}

		// String Changed
		private void PostText_TextChanged(object sender, EventArgs e)
		{
			pictureBox1.Refresh();
		}

		// Size Change
		private void Post_Resize(object sender, EventArgs e)
		{
			// ReDraw
			pictureBox1.Invalidate();
		}

		// Draw
		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			// Color Convertor
			ColorConverter ClConv = new ColorConverter();
			// ------------------------------
			//縦に白から黒へのグラデーションのブラシを作成
			//g.VisibleClipBoundsは表示クリッピング領域に外接する四角形
			LinearGradientBrush gb = new LinearGradientBrush(
					///g.VisibleClipBounds,
					e.ClipRectangle,
					Color.White,
					(Color)ClConv.ConvertFromString(AppStg.FooterColor),
					LinearGradientMode.Vertical);
			// ガンマ補正を有効に
			gb.GammaCorrection = true;
			// 四角を描く
			e.Graphics.FillRectangle(gb, e.ClipRectangle);
			// もし文字描画する設定なら
			if(AppStg.HideInformation == false){
				// -----------------------------------------------------------
				// 文字数を取得
				int LenghtBuf = StringLengthBuf(PostText.Text);
				//StringFormatオブジェクトの作成
				StringFormat sf = new StringFormat();
				// 描画幅を取得
				SizeF stringSize = e.Graphics.MeasureString(LenghtBuf.ToString(), Font, pictureBox1.Width, sf);
				// Get Brush
				SolidBrush Draw = new SolidBrush((Color)ClConv.ConvertFromString(AppStg.StringColor));
				// 描画
				e.Graphics.DrawString(LenghtBuf.ToString(), Font,
					LenghtBuf <= 140 ? Draw : Brushes.Red,
					pictureBox1.Width - stringSize.Width,
					pictureBox1.Height - stringSize.Height, sf);
				// -----------------------------------------------------------
				// 描画する文字を指定
				String DrawAc = "投稿: " + AppStg.TwitterAccs[AppStg.UsingAccountVal].ShowName +
					"[@" + AppStg.TwitterAccs[AppStg.UsingAccountVal].UserName + "] " +
					( AppStg.KiseiInfoShow ?
						"[残: " + GetKiseiNum(AppStg.TwitterAccs[AppStg.UsingAccountVal]).ToString() + "] " :
						"") +
					( PicturePath.Length != 0 ? "(画像: " + Path.GetFileName(PicturePath) + " )" : "");
				// 描画幅を取得
				stringSize = e.Graphics.MeasureString(DrawAc, Font, pictureBox1.Width, sf);
				// 描画
				e.Graphics.DrawString(DrawAc, Font, Draw, 0, pictureBox1.Height - stringSize.Height, sf);
			}
		}

		// Close Event
		private void Post_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(e.CloseReason == CloseReason.UserClosing){
				Hide();
				e.Cancel = true;
				return;
			}
			AppSettingAccess.SaveSetting(AppStg);
			notifyIcon1.Visible = false;
			PostShow.Dispose();
		}

		// Double Click Task Icon
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			Activate();
		}
	
		// Post Picture Select
		private void 投稿PToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create Instance
			OpenFileDialog ofd = new OpenFileDialog();
			// ---------------------------------------------
			// Set Default File
			ofd.FileName = _PictPath;
			// Set Extensions
			ofd.Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.bmp;*.gif|すべてのファイル(*.*)|*.*";
			// Set Other Setting
			ofd.Title = "投稿する画像を選択";
			ofd.AutoUpgradeEnabled = true;
			ofd.RestoreDirectory = true;
			// Open Dialog
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				// Set FilePath
				PicturePath = ofd.FileName;
			}
		}

		// Get ScreenShot and Post It
		private void スクリーンショットの投稿SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create Instance
			Captcha cpWindow = new Captcha();
			// Get Rect
			Rectangle ScRect = cpWindow.GetCaptcha();
			// if Minimam Size
			if(ScRect.Width == 0){
				// End
				return;
			}
			// Create Bitmap
			Bitmap Bmp = new Bitmap(ScRect.Width, ScRect.Height);
			// Create Graphic
			Graphics g = Graphics.FromImage(Bmp);
			// Get ScreenShot
			g.CopyFromScreen(ScRect.Location, new Point(0, 0), ScRect.Size);
			// Free
			g.Dispose();
			// Set ClipBoard
			Clipboard.SetImage(Bmp);
			// ClipBoard Picture Post Function
			クリップボードの画像を添付BToolStripMenuItem_Click(sender, e);
			// Add FilePath
			PictureType = 1;
			// Refresh
			Refresh();
		}

		// Post Clipboard Picture
		private void クリップボードの画像を添付BToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Check Clipboard Data
			if(Clipboard.ContainsImage() == false){
				// Message
				MessageBox.Show("貼り付けられる画像ファイルはありません。");
				// End
				return;
			}
			// Create Tmp File
			String TempPath = Path.GetTempFileName();
			// Save
			Clipboard.GetImage().Save(TempPath);
			// Add FilePath
			PicturePath = TempPath;
			PictureType = 2;
			// Refresh
			Refresh();
		}

		// Delete SelectedPicture
		private void 添付画像を破棄するDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PicturePath = String.Empty;
		}

		// Open the Config Dialog
		private void 設定ダイアログを開くOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create Instance
			Setting stWindow = new Setting(AppStg);
			// ----------------------------------------
			// Setting Change
			AppStg.WindowSize = Size;
			// Go to Account Management			
			AppStg = stWindow.SettingChange(this);
			// Dispose
			PostShow.Dispose();
			// Set HotKey
			MOD_KEY ModKey = (MOD_KEY)Enum.ToObject(typeof(MOD_KEY), AppStg.ShowModKey);
			PostShow = new HotKey(ModKey, AppStg.ShowKeyChar);
			// Event Add
			PostShow.HotKeyPush += new EventHandler(HotPush);
			// ReLoad
			Post_Load(sender, e);
		}
		
		// Close the Post Windozw
		private void 投稿ウィンドウを閉じるCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();
		}

		// Application Exit
		private void poltsの終了XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Setting Change
			AppStg.WindowSize = Size;
			// Program End
			Application.Exit();
		}

		// Length
		private int StringLengthBuf(String s){
			if(s == DefTextString){
				// default
				return 0;
			}
			// String Length
			return s.Length;
		}

		// Post Tweet
		private bool TweetPost(String s)
		{
			// if Empty Textbox, Refresh
			if(AppStg.NoResetString == false){
				PostText.Text = "";
				PostText.Refresh();
			}
			// if After Close
			if (AppStg.HideTweetWindow) { Hide(); }
			bool CheckOK = false;
			// if Check Kisei
			if (AppStg.ChangeAccOnKisei){
				int Val = AppStg.UsingAccountVal;
				// Check
				do{
					int Lenght = GetKiseiNum(AppStg.TwitterAccs[Val]);
					// If not Under 5
					if(Lenght >= 5){
						// Go
						CheckOK = true;
						AppStg.UsingAccountVal = Val;
						break;
					}
					// else Change
					Val = (Val+1)%AppStg.TwitterAccs.Count;
				}while(Val != AppStg.UsingAccountVal);
				// if Post unable
				if(CheckOK == false){
					// MessageBox
					MessageBox.Show("現在登録されている全アカウントで規制されているようです。");
					return false;
				}
			}
			// Create Twitter Service Instance
			TwitterService TwitServ = new TwitterService(
				AppStg.TwitterAccs[AppStg.UsingAccountVal].ConsKey,
				AppStg.TwitterAccs[AppStg.UsingAccountVal].ConsSecret
			);
			// OAuth
			TwitServ.AuthenticateWith(
				AppStg.TwitterAccs[AppStg.UsingAccountVal].AccessToken,
				AppStg.TwitterAccs[AppStg.UsingAccountVal].AccessSecret
			);
			CheckOK = true;
			// Check String
			while(CheckOK && AppStg.DualPost){
				// End
				CheckOK = false;
				// Loop
				foreach(String Tweet in BeforeTweets){
					// if Cmp
					if(Tweet != null && Tweet == s){
						// Add 
						s += "　";
						// Restart
						CheckOK = true;
						break;
					}
				}
			}
			// Check String Lenght
			if(BeforeTweets.Length > 0 && BeforeTweets[0] != null && s.Length == BeforeTweets[0].Length){
				// Add Space
				s += "　";
			}
			// Check
			if (String.IsNullOrWhiteSpace(s) || StringLengthBuf(s) > 140 || s == DefTextString){
				PostText.Text = s;
				// false
				return false;
			}
			// GetTweet
			TwitterStatus TwiStatus;
			// IF not Picture Tweet
			if(PicturePath == ""){
				// Send Tweet
				TwiStatus = TwitServ.SendTweet(new SendTweetOptions { Status = s });
			}
			// If Picture Tweet
			else{
				var stream = new FileStream(_PictPath, FileMode.Open);
				SendTweetWithMediaOptions opt = new SendTweetWithMediaOptions();
				opt.Status = s;
				opt.Images = new Dictionary<string, Stream> { { "image", stream } };
				// Send Tweet
				TwiStatus = TwitServ.SendTweetWithMedia(opt);
				// If Reset Flag
				if(AppStg.NoResetString == false){
					// If Temp File
					if(PictureType >= 1){
						// File Delete
						File.Delete(_PictPath);
					}
					// Picture reset
					PicturePath = "";
				}
			}
			// if ResetTime over
			if(PostRstTime == null || ((DateTime)PostRstTime - TwiStatus.CreatedDate).Hours < 0){
				// Set
				PostRstTime	= TwiStatus.CreatedDate;
			}
			// Add List
			BeforeTweets[LastAddPlace] = s;
			LastAddPlace = (LastAddPlace + 1)%15;
			return true;
		}

		// Get Kisei Number
		private int GetKiseiNum(TwAccount Acc, bool Reload = false)
		{
			// Kisei Num
			const int RETURN_MAX = 128;
			// if different
			if(Account != null && Account.UserName == Acc.UserName && !Reload){
				// return
				return Buf;
			}
			// copy
			Account = Acc;
			// Reset
			Buf = RETURN_MAX;
			// for get my TL
			ListTweetsOnUserTimelineOptions opt = new ListTweetsOnUserTimelineOptions();
			// set my account
			opt.ScreenName = Acc.UserName;
			// over RETURN_MAX
			opt.Count = RETURN_MAX;
			// Create Twitter Service Instance
			TwitterService TwitServ = new TwitterService(
				Account.ConsKey, Account.ConsSecret
			);
			// OAuth
			TwitServ.AuthenticateWith(
				Account.AccessToken, Account.AccessSecret
			);
			// Get
			var Tweets = TwitServ.ListTweetsOnUserTimeline(opt);
			// foreach
			foreach(var Tweet in Tweets){
				// Span Get
				TimeSpan Ts =
					(PostRstTime == null ? DateTime.UtcNow : (DateTime)PostRstTime) - Tweet.CreatedDate;
				// if 3 Hours over
				if(Ts.Hours >= 3){
					// if ResetTime is null
					if(PostRstTime == null){
						// Set
						PostRstTime = Tweet.CreatedDate.AddHours(3);
					}
					// End
					break;
				}
				// Value Minus
				Buf--;
			}
			// Result
			return Buf;
		}

		// HotKey Push
		private void HotPush(object sender, EventArgs e)
		{
			// Visible Change
			Visible = !Visible;
			if(Visible){
				Activate();
			}
		}

		// Remover
		private FormDragMover FormMover;
		// Resizer
		private FormDragResizer FormResizer;

		// ApplicationSetting Copy
		private ApplicationSetting AppStg;

		// Add Picture FilePath
		private String PicturePath
		{
			get{
				switch(PictureType){
					case 1:
						return "Screen Shot";
					case 2:
						return "Clip Board";
					default:
						return _PictPath;
				}
			}
			set{
				if(value == String.Empty){
					PictureType = 0;
				}
				_PictPath = value;
				添付画像を破棄するDToolStripMenuItem.Enabled =	(value != String.Empty);
				pictureBox1.Refresh();
			}
		}
		private String _PictPath = "";
		private int PictureType;

		// TextBox Default String
		private String DefTextString;

		// Before Post(x10)
		private String[] BeforeTweets = new String[15];
		private int LastAddPlace = 0;

		// HotKey
		private HotKey PostShow;

		// Instance
		private TwAccount Account = null;
		// Buf
		private int Buf = 0;
		// PostResetTime
		private DateTime? PostRstTime = null;
	}
}
