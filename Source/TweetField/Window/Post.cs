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
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using TweetSharp;

namespace TweetField
{
	public partial class Post : Form
	{
		// Constructor
		public Post()
		{
			// Load
			AppStg = AppSettingAccess.LoadSetting();
			// if Account Value is 0
			if (AppStg.UsingAccountVal < 0){
				// Create Instance
				var stWindow = new Setting(AppStg);
				// Setting Change
				AppStg = stWindow.SettingChange(this);
				// If Result is not OK
				if(stWindow.DialogResult != DialogResult.OK || AppStg == null){
					// Exit
					Close();
					Application.Exit();
					return;
				}
			}
			// Reset
			InitializeComponent();
			// Create Instance
			FormResizer	= new FormDragResizer(this, FormDragResizer.ResizeDirection.All, 8);
			FormMover	= new FormDragMover(this, 8);
			// Add Event
			FormResizer.AddMouseEvent(PostText);
			FormResizer.AddMouseEvent(pictureBox1);
			FormResizer.AddMouseEvent(UserIcon);
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
			// Get Regulation
			if (AppStg.RegulationInfoShow) { GetRegulationNum(AppStg.TwitterAccs[AppStg.UsingAccountVal]); }
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
			// PictureBox Size Set
			tableLayoutPanel1.RowStyles[1] = new RowStyle(SizeType.Absolute,
				(AppStg.HideInformation ? 0 : 22));
			// Menu Create
			CreateMenuList(AppStg);
			// MyIcon Get & Set
			MyIconGetAndSet(AppStg.TwitterAccs[AppStg.UsingAccountVal]);
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
				// If Edit Text
				if(PostText.Text != DefTextString){
					// Post Text Tweet
					bool Result = TweetPost(PostText.Text);
					// TextColor Reset
					PostText.ForeColor = Color.Black;
					// if Result is false
					if(Result == false){
						// Not Do Default Key Function
						e.Handled = true;
						// end
						return;
					}
					// Regulation Check
					GetRegulationNum(AppStg.TwitterAccs[AppStg.UsingAccountVal], true);
					// Not Do Default Key Function
					e.SuppressKeyPress = true;
				}
			}
			// If Push Ctrl + A
			else if(e.KeyCode == Keys.A && e.Control){
				// All Select
				PostText.SelectAll();
				// Not Do Default Key Function
				e.SuppressKeyPress = true;
			}
			// If Push Escape Key
			else if(e.KeyCode == Keys.Escape){
				// Form Close
				Hide();
				// Not Do Default Key Function
				e.SuppressKeyPress = true;
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
			// If Draw Gradation
			if(AppStg.Gradation && AppStg.HideInformation == false){
				// Create Gradation Brush
				LinearGradientBrush gb = new LinearGradientBrush(
						e.ClipRectangle,
						Color.Transparent,
						(Color)ClConv.ConvertFromString(AppStg.FooterColor),
						LinearGradientMode.Vertical);
				// Gamma Correction is true
				gb.GammaCorrection = true;
				// Draw rectangle
				e.Graphics.FillRectangle(gb, e.ClipRectangle);
			} else {
				// Create Brush
				SolidBrush sb = new SolidBrush((Color)ClConv.ConvertFromString(AppStg.FooterColor));
				// Draw
				e.Graphics.FillRectangle(sb, e.ClipRectangle);
			}
			// If Draw Text
			if(AppStg.HideInformation == false){
				// -----------------------------------------------------------
				// Get
				int LenghtBuf = 140 - StringLengthBuf(PostText.Text);
				// Create StringFormat
				StringFormat sf = new StringFormat();
				// Get
				SizeF stringSize = e.Graphics.MeasureString(LenghtBuf.ToString(), Font, pictureBox1.Width, sf);
				// Get Brush
				SolidBrush Draw = new SolidBrush((Color)ClConv.ConvertFromString(AppStg.StringColor));
				// Draw
				e.Graphics.DrawString(LenghtBuf.ToString(), Font,
					LenghtBuf >= 0 ? Draw : ( AppStg.SplitText ?  Brushes.Pink :  Brushes.Red),
					pictureBox1.Width - stringSize.Width,
					pictureBox1.Height - stringSize.Height, sf);
				// -----------------------------------------------------------
				// Set Draw String
				String DrawAc = PictureBoxShowText();
				// Get
				stringSize = e.Graphics.MeasureString(DrawAc, Font, pictureBox1.Width, sf);
				// Draw
				e.Graphics.DrawString(DrawAc, Font, Draw, 0, pictureBox1.Height - stringSize.Height, sf);
			}
		}

		// Icon Click
		private void UserIcon_Click(object sender, EventArgs e)
		{
			// If Account Count <= 1
			if(AppStg.TwitterAccs.Count <= 1){
				// Nothing
				return;
			}
			// Account Change ( +1 )
			AppStg.UsingAccountVal = (AppStg.UsingAccountVal+1)%AppStg.TwitterAccs.Count;
			// Reload
			Post_Load(null, null);
			// RePaint
			pictureBox1.Refresh();
		}

		// Double Click Task Icon
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			Activate();
		}

		// Translate Japanese <- -> English
		private void テキストを英訳NToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// If is Text Japanese
			if(!Regex.Match(PostText.Text, "^[a-zA-Z]").Success){
				// Open Google Translate(Ja -> En)
				new Browser("https://translate.google.co.jp/#ja/en/" + PostText.Text).Show();
			}
			// else
			else {
				// Open Google Translate(En -> Ja)
				new Browser("https://translate.google.co.jp/#en/ja/" + PostText.Text).Show();
			}
		}

		// Edit Auto Hash Tag
		private void ハッシュタグの設定HToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create Instance
			var Dlg = new TagEditer(ref AppStg);
			// Show
			Dlg.ShowDialog();
		}

		// Edit My CopyPaste Word
		private void コピペワード編集EToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create Instance
			var Dlg = new CopyPasteView(ref AppStg, PostText.SelectedText);
			// Show
			Dlg.ShowDialog();
			// if Call
			if(Dlg.CallString != ""){
				// Add Text
				PostText.SelectedText = Dlg.CallString;
			}
			// Menu Reload
			CreateMenuList(AppStg);
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
			// Hide TweetWindow
			Hide();
			// Get Rect
			Rectangle ScRect = cpWindow.GetCaptcha();
			// if Minimam Size
			if(ScRect.Width == 0){
				// Show & Active
				Show();
				Activate();
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
			// Show & Active
			Show();
			Activate();
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

		// Check Picture View
		private void 添付した画像を確認するCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Create Instance
			var CheckForm = new PictureCheck(_PictPath);
			// Show
			CheckForm.ShowDialog();
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
			ApplicationSetting As;
			// ----------------------------------------
			// Setting Change
			AppStg.WindowSize = Size;
			// Go to Account Management			
			As = stWindow.SettingChange(null);
			// if result is abort
			if(stWindow.DialogResult == DialogResult.Abort || As == null){
				// return
				return;
			}
			AppStg = As;
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

		// Text Length
		private int StringLengthBuf(String s){
			int Result = s.Length;
			if(s == DefTextString){
				// default
				return 0;
			}
			foreach(var Str in AppStg.HashTagList){
				Result += Str.Length + 1;
			}
			// String Length
			return Result;
		}

		// Post Tweet
		private bool TweetPost(String s)
		{
			// Back Up
			String BackUpStr = s;
			// is Empty
			if ((PicturePath == "" && String.IsNullOrWhiteSpace(s))){
				// Refresh
				PostText.Refresh();
				// false
				return false;
			}
			// if Text is Empty
			if(!AppStg.NoResetString){ PostText.Text = ""; }
			// if After Close
			if(AppStg.HideTweetWindow){ Hide(); }
			// HashTag Add
			foreach(var Tag in AppStg.HashTagList){
				// Add
				s += " " + Tag;
			}
			// String Add Error
			if(PicturePath == "" && !StringAddSpace(ref s)){
				// Message
				return PostErrorMessageShow(BackUpStr, "その文字列は既に投稿されています．\n"+
					"このエラーを回避するためには，連投回避オプションにチェックを入れるか" +
					"10ツイート以内に同じツイートをしないようにしてください．");
			}
			// if Lenght is over 140
			if(StringLengthBuf(s) > 140){
				if(AppStg.SplitText){
					return TweetLongPost(s);
				} else {
					// Message
					return PostErrorMessageShow(BackUpStr, "文字数が超過しています[文字数: " +
						StringLengthBuf(s).ToString() + "]．\n" +
						"規制回避のためのスペース追加で超過した可能性があります．また，分割連投オプションで回避できる場合があります．");
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
				// If no Reset Flag
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
			if(TwiStatus != null
				&& (PostRstTime == null
				|| ((DateTime)PostRstTime - TwiStatus.CreatedDate).TotalSeconds < 0)){
				// Set
				PostRstTime	= TwiStatus.CreatedDate.AddHours(3);
			}
			// Get Regulation Num
			var Regu = GetRegulationNum(AppStg.TwitterAccs[AppStg.UsingAccountVal]);
			// if Tweet is NULL and Regulation Num is under 0, Account Change
			if(TwiStatus == null
				&& Regu != null
				&& Regu <= 0){
				// Error Show and RePost
				return !AccountChange(BackUpStr) && TweetPost(s);
			}
			// else if Tweet is NULL
			else if(TwiStatus == null){
				// Error Show
				return PostErrorMessageShow(s);
			}
			// Add List
			BeforeTweets[LastAddPlace] = s;
			LastAddPlace = (LastAddPlace + 1)%10;
			return true;
		}

		// Post Long Tweet
		private bool TweetLongPost(String s, bool MaxPost = true)
		{
			// Hit Chars
			List<char> HitChars = new List<char>(new char[]{'、', '。', '，', '．', '\n'});
			// Temp
			int PostTextLenght = (MaxPost ? 140 : 139);
			// If Add [Next], true
			bool IsAddNext = (AppStg.SplitInsert_NEXT && s.Length > PostTextLenght);
			// ----------------------------------------
			// If Split Place Set
			if(AppStg.SplitAtSpace && s.Length > PostTextLenght){
				for(int i = PostTextLenght; ; i--){
					if(HitChars.Exists(delegate(char c){ return c == s[i]; })){
						PostTextLenght = i + 1;
						break;
					}
				}
			}
			// Post Text Set
			String PostStr = s.Substring(0, Math.Min(PostTextLenght, s.Length)) + (IsAddNext ? "[続く]" : "");
			// Post Tweet
			TweetPost(PostStr);
			// if Text Lenght over PostTextLenght
			if(s.Length > PostTextLenght){
				// RePost
				return TweetLongPost(s.Substring(PostTextLenght, s.Length - PostTextLenght), !MaxPost);
			}
			// End
			return true;
		}

		// Get Regulation Number
		private int? GetRegulationNum(TwAccount Acc, bool Reload = false)
		{
			try{
				// Regulation Num
				const int RETURN_MAX = 300;
				// if not used  RegulationNum
				if(AppStg.RegulationInfoShow == false){
					// set
					RemainRegulationNum = RETURN_MAX;
					// return MAX
					return RETURN_MAX;
				}
				// if different
				if(Account != null && Account.UserName == Acc.UserName && !Reload){
					// return
					return RemainRegulationNum;
				}
				// copy
				Account = Acc;
				// Reset
				RemainRegulationNum = RETURN_MAX;
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
				// if Tweets is null
				if(Tweets == null){
					// Buf Set
					RemainRegulationNum = null;
					// return 
					return RemainRegulationNum;
				}
				// Save Before Tweet
				TwitterStatus BeforeTwi = null;
				// foreach
				foreach(var Tweet in Tweets){
					// Span Get
					TimeSpan Ts =
						(PostRstTime == null ? DateTime.UtcNow : (DateTime)PostRstTime) - Tweet.CreatedDate;
					// if 3 Hours over
					if(Ts.Hours >= 3){
						// if ResetTime is null
						if(PostRstTime == null){
							// if BeforeTwi is null
							if(BeforeTwi != null){
								// Set
								PostRstTime = BeforeTwi.CreatedDate.AddHours(3);
							}
							// else
							else{
								// Reset
								PostRstTime = null;
							}
						}
						// End
						break;
					}
					// Value Minus
					RemainRegulationNum--;
					// Save
					BeforeTwi = Tweet;
				}
			}catch( Exception ){}
			// Result
			return RemainRegulationNum;
		}

		// Account Change
		private bool AccountChange(String Post)
		{
			// Get Now Select
			int nSelect = AppStg.UsingAccountVal;
			int acCount = AppStg.TwitterAccs.Count;
			// If Account Num is not over 2
			if(acCount <= 1){
				// Message
				return PostErrorMessageShow(Post,
					"現在規制されているようです．新しくアカウントを登録するか，規制が解除されるまでしばらくお待ち下さい．");
			}
			// Is Account Change
			if(AppStg.ChangeAccOnRegulation == false){
				// Message
				return PostErrorMessageShow(Post,
					"現在規制されているようです．アカウントを切り替えるか，規制が解除されるまでしばらくお待ち下さい．");
			}
			// Loop
			for(int Val = (nSelect+1)%acCount; Val == (nSelect+acCount-2)%acCount; Val = (Val+1)%acCount){
				// If Regulation Num Over 0
				if(GetRegulationNum(AppStg.TwitterAccs[Val]) > 0){
					// Account Change
					AppStg.UsingAccountVal = Val;
					// End
					return true;
				}
			}
			// Error
			return PostErrorMessageShow(Post,
				"現在登録されている全てのアカウントで規制されているようです．");
		}

		// For Dual Post
		private bool StringAddSpace(ref String s)
		{
			// Check String Lenght
			if(AppStg.DualPost && BeforeTweets[0] != null && s.Length == BeforeTweets[0].Length){
				// Add Space
				s += "　";
			}
			// Check String
			foreach(String Tweet in BeforeTweets){
				// if Equal
				if(Tweet != null && Tweet == s){
					// if not allow add space
					if(!AppStg.DualPost){
						// End
						return false;
					}
					// Add 
					s += "　";
					// Restart
					StringAddSpace(ref s);
				}
			}
			return true;
		}

		// PictureBox Text
		private String PictureBoxShowText()
		{
			// Return String
			String Result = AppStg.InformationText;
			// If add Picture
			if(PicturePath.Length != 0){
				// Add Picture Name
				Result = Result.Replace("+Information", AppStg.InformationPict);
				Result = Result.Replace("+PictureInfo", AppStg.InformationPict);
			}
			// if Show Regulation Info
			if(AppStg.RegulationInfoShow){
				Result = Result.Replace("+Information", AppStg.InformationRegu);
				Result = Result.Replace("+RegulationInfo", AppStg.InformationRegu);
			}
			// Default Value
			Result = Result.Replace("+Information", "");
			Result = Result.Replace("+PictureInfo", "");
			Result = Result.Replace("+RegulationInfo", "");
			// Regulation Value
			var RgVal = GetRegulationNum(AppStg.TwitterAccs[AppStg.UsingAccountVal]);
			// Replace
			Result = Result.Replace("#ShowName", AppStg.TwitterAccs[AppStg.UsingAccountVal].ShowName);
			Result = Result.Replace("#UserID", AppStg.TwitterAccs[AppStg.UsingAccountVal].UserName);
			Result = Result.Replace("#RegulationNum", (RgVal != null ? RgVal.ToString() : "ERROR"));
			Result = Result.Replace("#RegulationResetLongTime",
				(PostRstTime != null ? PostRstTime.Value.ToLocalTime().ToLongTimeString(): "----"));
			Result = Result.Replace("#RegulationResetShortTime",
				(PostRstTime != null ? PostRstTime.Value.ToLocalTime().ToShortTimeString(): "----"));
			Result = Result.Replace("#RegulationResetDate",
				(PostRstTime != null ? PostRstTime.Value.ToLocalTime().ToShortDateString(): "----"));
			Result = Result.Replace("#RegulationResetDateAndTime",
				(PostRstTime != null ? PostRstTime.Value.ToLocalTime().ToShortDateString() + PostRstTime.Value.ToLocalTime().ToShortTimeString(): "----"));
			Result = Result.Replace("#PictureFullPath", PicturePath);
			Result = Result.Replace("#PicturePath", Path.GetFileName(PicturePath));
			// return
			return Result;
		}

		// Post Error Show
		private bool PostErrorMessageShow(String PostData, String Reason = "")
		{
			// Switch UserSelect
			switch(new PostError(PostData, Reason).ShowDialog(this)){
				case DialogResult.Ignore:
					// Retry
					TweetPost(PostData);
					// TextColor Reset
					PostText.ForeColor = Color.Black;
					return true;
				case DialogResult.Retry:
					// Return
					PostText.Text = PostData;
					// Select Reset
					PostText.Select(PostText.Text.Length,0);
					// TextColor Reset
					PostText.ForeColor = Color.Black;
					// Show
					Show();
					Activate();
					return false;
				case DialogResult.Cancel:
					// Text Reset
					PostText.Text = "";
					// TextColor Reset
					PostText.ForeColor = Color.Black;
					return false;
				default:
					return false;
			}
		}

		// Create Menu List
		private void CreateMenuList(ApplicationSetting As)
		{
			// --- Cleared
			// Copy
			ToolStripItem[] MenuLists = new ToolStripItem[
				文字列処理SToolStripMenuItem.DropDownItems.Count];
			文字列処理SToolStripMenuItem.DropDownItems.CopyTo(MenuLists, 0);
			// All Get and Remove
			foreach(ToolStripItem Item in MenuLists){
				// if Name isnot ADDMENUITEMS, continue
				if(Item.Name != "ADDMENUITEMS"){ continue; }
				// Remove
				文字列処理SToolStripMenuItem.DropDownItems.Remove(Item);
			}
			// --- Add
			// Search Show Setting
			var AddList = As.CopyPasteWords.FindAll(delegate(CopyWords Cw){ return Cw.IsMenuShow; });
			// If Empty, UnVisible Separator
			toolStripSeparator1.Visible = (AddList.Count != 0);
			// If not Empty, Create Menus
			if(AddList.Count > 0){
				// Insert Place
				int AddIndex = 0;
				// foreach
				foreach(var Val in AddList){
					// Create New Menu
					var NewItem = new ToolStripMenuItem(); 
					// Set Property
					NewItem.Text = Val.ShortText;
					NewItem.Name = "ADDMENUITEMS";
					// Event Set
					NewItem.Click += delegate(object o, EventArgs e){
						// If not Selected
						if(PostText.SelectedText == "" && Val.Text.Contains("%Select%")){
							// All Selected
							PostText.SelectAll();
						}
						// Add Text
						PostText.SelectedText = Val.GetString(PostText.SelectedText);
					};
					// Add New Menu Item
					文字列処理SToolStripMenuItem.DropDownItems.Insert(AddIndex, NewItem);
					// Place Add
					AddIndex++;
				}
			}
		}

		// Get / Set Icon
		private void MyIconGetAndSet(TwAccount Ta)
		{
			// If Icon not Showed
			if(AppStg.IconShowed == false){
				// Width = 0
				tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 0);
				// end
				return;
			}
			// Create Twitter Service Instance
			TwitterService TwitServ = new TwitterService(Ta.ConsKey, Ta.ConsSecret);
			// OAuth
			TwitServ.AuthenticateWith(Ta.AccessToken,Ta.AccessSecret);
			// Get MyData
			var UserData = TwitServ.GetUserProfile(new GetUserProfileOptions());
			// Icon Set
			UserIcon.ImageLocation = UserData.ProfileImageUrl;
			// Width set
			tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 41);
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
				添付画像を破棄するDToolStripMenuItem.Visible	 = (value != String.Empty);
				添付した画像を確認するCToolStripMenuItem.Visible = (value != String.Empty);
				pictureBox1.Refresh();
			}
		}
		private String _PictPath = "";
		private int PictureType;

		// TextBox Default String
		private String DefTextString;

		// Before Post(x10)
		private String[] BeforeTweets = new String[10];
		private int LastAddPlace = 0;

		// HotKey
		private HotKey PostShow;

		// Instance
		TwAccount Account = null;
		// RemainRegulationNum
		private int? RemainRegulationNum;
		// PostResetTime
		private DateTime? PostRstTime = null;
	}
}
