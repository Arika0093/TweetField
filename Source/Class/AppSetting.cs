﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TweetField
{
	public class ApplicationSetting
	{
		// ----------------------------------
		//	Default Constructor
		// ----------------------------------
		public ApplicationSetting()
		{
			// ------------------------------
			// Account Setting
			TwitterAccs			= new List<TwAccount>();	// Create Enpty List
			UsingAccountVal		= -1;						// Account Num is Empty
			// ------------------------------
			// CopyWords
			CopyPasteWords		= new List<CopyWords>();	// Create Enpty List
			// ------------------------------
			// Tags
			HashTagList			= new List<string>();		// Create Enpty List
			HashTagHistory		= new List<string>();		// Create Enpty List
			// ------------------------------
			// Set Font
			SysFontName	= SystemInformation.MenuFont.Name;	// Default Font Name
			SysFontSize			= 9;						// Default Font Size
			// ------------------------------
			// Translator API Key
			ConsumerID			= "";						// Empty
			ClientSecret		= "";						// Empty
			// ------------------------------
			// Set PostWindow Setting
			// Default Format
			InformationText		= "投稿: #ShowName [@#UserID] +Information";
			InformationRegu		= "[残: #RegulationNum / Reset: #RegulationResetLongTime]";
			InformationPict		= "[画像: #PicturePath]";
			InformationSomePicts= "{0}枚添付中";
			// Basic
			ShowKeyChar			= Keys.None;				// Show/Hide Key
			ShowModKey			= (int)MOD_KEY.CONTROL;		// Mod Key
			ShowWindowPosition	= 0;						// Show LeftDown
			WindowSize			= new Size(433, 63);		// Default Size
			PostKeyType			= 0;						// Enter Post
			// Font Color Set
			FontColor			= "Black";
			// Footer Color Set
			FooterColor			= "DodgerBlue";
			// String Color Set
			StringColor			= "White";
			// Other
			IconShowed			= true;
			SplitText			= true;
			SplitAtSpace		= true;
			SplitInsert_NEXT	= false;
			HideTweetWindow		= true;						// Window Hide After Tweet
			DualPost			= false;
			NoResetString		= false;
			HideInformation		= false;					// Hide Out of Focus
			Gradation			= false;
		}
		// ----------------------------------
		//	Twitter Account Data
		// ----------------------------------
		public int			UsingAccountVal;			// TweetField Default Post Account
		public List<TwAccount>
							TwitterAccs;				// Twitter Accounts
		// ----------------------------------
		//	CopyPaste Word
		// ----------------------------------
		public List<CopyWords>
							CopyPasteWords;				// Copype Texts
		// ----------------------------------
		//	Hash Tag
		// ----------------------------------
		public List<String>	HashTagList;				// Add Bind Hash Tags
		public List<String>	HashTagHistory;				// HashTag Suggest History
		// ----------------------------------
		//	Font Setting
		// ----------------------------------
		public String		SysFontName;				// System Using FontName
		public float		SysFontSize;				// System Using FontSize
		// ----------------------------------
		//	Translate
		// ----------------------------------
		public String		ConsumerID;					// MS Translator API Consumer ID
		public String		ClientSecret;				// Secret Words
		// ----------------------------------
		//	Tweet Window Setting
		// ----------------------------------
		public String		InformationText;			// Information Text Format @ PictureControl
		public String		InformationRegu;			// Information Text(Regulation Ver)
		public String		InformationPict;			// Information Text(Picture Ver)
		public String		InformationSomePicts;		// Information Text(Some Picture Ver)
		public Size			WindowSize;					// PostForm Window Size
		public Keys			ShowKeyChar;				// Show/Hide Key
		public int			ShowModKey;					// Key Option
		public int			ShowWindowPosition;			// First Show Position
		public int			PostKeyType;				// PostKey Value
		public String		FontColor;					// PostForm's Text Font Color
		public String		FooterColor;				// Window of Footer Color
		public String		StringColor;				// String Color
		public bool			DualPost;					// Add Some String
		public bool			NoResetString;				// 
		public bool			RegulationInfoShow;			// 
		public bool			ChangeAccOnRegulation;		//
		public bool			IconShowed;					// If false, Icon in PostBox doesn't show
		public bool			SplitText;					// If true, Split text when over text's lenght 140
		public bool			SplitAtSpace;				// If true, Split text at space, peliod, and enter
		public bool			SplitInsert_NEXT;			// If true. Splited text
		public bool			HideTweetWindow;			// Hide Window after Tweet
		public bool			HideInformation;			// Hide Window out Focus
		public bool			Gradation;					// Is Draw Gradation
		public bool			UserSuggestUsed;			// User suggest
		public bool			LoadPictureAtSuggest;		// Is Get Picture
		public bool			AutoRun;					// AutoRunCheck
	}

	public class TwAccount
	{
		// ----------------------------------
		//	User Status
		// ----------------------------------
		public String		UserName;					// Account User Name
		public String		ShowName;					// Show Name
		public String		ConsKey;					// Consumer Key
		public String		ConsSecret;					// Consumer Secret Key
		public String		AccessToken;				// Token
		public String		AccessSecret;				// SecretToken
	}

	public class CopyWords
	{
		// ----------------------------------
		//	Data
		// ----------------------------------
		public String		Text;						// Text
		public String		ShortText;					// ShortText(For Menu Show)
		public bool			IsMenuShow;					// MenuShow?
		public bool			IsRandomize;				// Random Select?
		// ----------------------------------
		//	Function
		// ----------------------------------
		public String		GetString(String Selected)
		{
			// Result
			String Result = "";
			// If Randomize
			if(IsRandomize){
				// Random Calc
				var Rndm = new Random();
				// Result Text
				String[] Results = Text.Split( new String[]{ "|||" }, StringSplitOptions.RemoveEmptyEntries);
				// Get Randomize
				Result = Results[Rndm.Next(Results.Length)];
			}
			// Else
			else {
				// Get
				Result = Text;
			}
			// Replace to SelectText
			Result = Result.Replace("%Select%", Selected);
			// Replace from \n to \r\n
			Result = Result.Replace("\n", "\r\n").Trim(new char[]{' ', '\r', '\n'});
			// Return
			return Result;
		}
	}

	public class AppSettingAccess
	{
		public static ApplicationSetting LoadSetting(String XmlPath = "", bool BackupCopy = true)
		{
			// if XmlPath is ""
			if (XmlPath == "") { XmlPath = XmlFileDefaultPath(); }
			// if not Exist Path
			if (File.Exists(XmlPath)){
				// if filesize is 0byte
				FileStream fs = File.Open(XmlPath, FileMode.Open);
				if (fs.Length != 0){
					// Create XmlSerializer Object
					XmlSerializer Srl = new XmlSerializer(typeof(ApplicationSetting));
					// Read and Deserialize
					ApplicationSetting aps = (ApplicationSetting)Srl.Deserialize(fs);
					// Close
					fs.Close();
					return aps;
				}
				else {
					fs.Close();
				}
			}
			// Search Backup File
			var BackupPath = XmlFileBackupPath(XmlPath);
			if (!File.Exists(BackupPath)){
				return new ApplicationSetting();
			}
			if (BackupCopy){
				// Copy
				File.Copy(BackupPath, XmlPath, true);
				MessageBox.Show("設定ファイル読み込み時にエラーが発生しました。\nバックアップからの読み込みを試みます。");
				return LoadSetting(XmlPath, false);
			}
			else {
				MessageBox.Show("読み込みに失敗しました。お手数ですが再設定をお願いします。");
				return new ApplicationSetting();
			}
		}
	
		public static void SaveSetting(ApplicationSetting Data, String XmlPath = "")
		{
			// if XmlPath is ""
			if(XmlPath == ""){XmlPath = XmlFileDefaultPath();}
			// Create Serializer
			XmlSerializer Srl = new XmlSerializer(typeof(ApplicationSetting));
			// Open File
			FileStream fs = new FileStream(XmlPath, FileMode.Create);
			// Write
			Srl.Serialize(fs, Data);
			// BackupFolder Check
			if(!Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Backup\")){
				// Create
				Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Backup\");
			}
			// Backup Generate
			File.Copy(XmlPath, XmlFileBackupPath(XmlPath), true);
			// Close
			fs.Close();
		}

		private static String XmlFileDefaultPath()
		{
			return Path.GetDirectoryName(Application.ExecutablePath) + @"\TwiField.xml";
		}

		private static String XmlFileBackupPath(String XmlPath)
		{
			return Path.GetDirectoryName(Application.ExecutablePath) + @"\Backup\" + Path.GetFileNameWithoutExtension(XmlPath) + ".xml";
		}

	};
}
