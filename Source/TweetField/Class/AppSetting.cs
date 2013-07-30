using System;
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
			// Color Convertor
			ColorConverter ClConv = new ColorConverter();
			// ------------------------------
			// Account Setting
			TwitterAccs			= new List<TwAccount>();	// Create Enpty List
			UsingAccountVal		= -1;						// Account Num is Empty
			// ------------------------------
			// Set Font
			SysFontName	= SystemInformation.MenuFont.Name;	// Default Font Name
			SysFontSize			= 9;						// Default Font Size
			// ------------------------------
			// Set PostWindow Setting
			ShowKeyChar			= Keys.None;				// Show/Hide Key
			ShowModKey			= (int)MOD_KEY.CONTROL;		// Mod Key
			ShowWindowPosition	= 0;						// Show LeftDown
			WindowSize			= new Size(433, 63);		// Default Size
			PostKeyType			= 0;						// Enter Post
			// Font Color Set
			FontColor			= ClConv.ConvertToString(Color.Black);
			// Footer Color Set
			FooterColor			= ClConv.ConvertToString(Color.DeepSkyBlue);
			// String Color Set
			StringColor			= ClConv.ConvertToString(Color.DimGray);
			HideTweetWindow		= true;						// Window Hide After Tweet
			HideInformation		= false;					// Hide Out of Focus
		}
		// ----------------------------------
		//	Twitter Account Data
		// ----------------------------------
		public int			UsingAccountVal;			// TweetField Default Post Account
		public List<TwAccount>
							TwitterAccs;				// Twitter Accounts
		// ----------------------------------
		//	Font Setting
		// ----------------------------------
		public String		SysFontName;				// System Using FontName
		public float		SysFontSize;				// System Using FontSize
		// ----------------------------------
		//	Tweet Window Setting
		// ----------------------------------
		public Size			WindowSize;					// PostForm Window Size
		public Keys			ShowKeyChar;				// Show/Hide Key
		public int			ShowModKey;					// Key Option
		public int			ShowWindowPosition;			// First Show Position
		public int			PostKeyType;				// PostKey Value
		public String		FontColor;					// PostForm's Text Font Color
		public String		FooterColor;				// Window of Footer Color
		public String		StringColor;				// String Color
		public bool			HideTweetWindow;			// Hide Window after Tweet
		public bool			HideInformation;			// Hide Window out Focus
	}

	public class TwAccount
	{
		// ----------------------------------
		//	User Status
		// ----------------------------------
		public String		UserName;					// Account User Name
		public String		ConsKey;					// Consumer Key
		public String		ConsSecret;					// Consumer Secret Key
		public String		AccessToken;				// Token
		public String		AccessSecret;				// SecretToken
	}

	public class AppSettingAccess
	{
		public static ApplicationSetting LoadSetting(String XmlPath = "")
		{
			// if XmlPath is ""
			if (XmlPath == "") { XmlPath = XmlFileDefaultPath(); }
			// if not Exist Path
			if (!File.Exists(XmlPath)){return new ApplicationSetting();}
			// XmlSerializerオブジェクトを作成
			XmlSerializer Srl = new XmlSerializer(typeof(ApplicationSetting));
			//読み込むファイルを開く
			FileStream fs = new FileStream( XmlPath, FileMode.Open);
			//XMLファイルから読み込み、逆シリアル化する
			ApplicationSetting aps = (ApplicationSetting)Srl.Deserialize(fs);
			//ファイルを閉じる
			fs.Close();
			return aps;
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
			// Close
			fs.Close();
		}

		private static String XmlFileDefaultPath()
		{
			return Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".xml";
		}

	};
}
