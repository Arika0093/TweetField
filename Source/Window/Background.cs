using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TweetField
{
	public partial class Background : Form
	{
		private ApplicationSetting aps;
		private Setting stWindow = null;
		private Post psWindow = null;
		private HotKey PostShow = null;

		public Background()
		{
			// Reset
			InitializeComponent();
		}

		public void DelIcon()
		{
			PostShow.Dispose();
			notifyIcon1.Visible = false;
		}

		private void 投稿PToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(psWindow == null){
				// Create Instance
				psWindow = (psWindow == null ? new Post(aps) : psWindow);
				// Setting Change
				psWindow.Show(this);
			}
			else{
				if(!psWindow.Visible){psWindow.Visible = true;}
				psWindow.Activate();
			}
		}

		private void 各種設定SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(stWindow == null){
				// Create Instance
				stWindow = new Setting(aps);
				// Setting Change
				aps = stWindow.SettingChange(this);
				// Dispose
				PostShow.Dispose();
				// Set HotKey
				MOD_KEY ModKey = (MOD_KEY)Enum.ToObject(typeof(MOD_KEY), aps.ShowModKey);
				PostShow = new HotKey(ModKey, aps.ShowKeyChar);
				// Event Add
				PostShow.HotKeyPush += new EventHandler(HotPush);
				// null
				stWindow = null;
			}
			else
			{
				// Set Focus
				stWindow.Focus();
			}
		}

		private void アプリケーションの終了XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// End
			Close();
		}

		private void Background_Load(object sender, EventArgs e)
		{
			// Load
			aps = AppSettingAccess.LoadSetting();
			// if Account Value is 0
			if (aps.UsingAccountVal < 0)
			{
				// Create Instance
				stWindow = new Setting(aps);
				// Setting Change
				aps = stWindow.SettingChange(this);
				// if Account Value is 0
				if (aps.UsingAccountVal < 0)
				{
					// End
					Close();
				}
				stWindow = null;
			}
			// Set HotKey
			MOD_KEY ModKey = (MOD_KEY)Enum.ToObject(typeof(MOD_KEY), aps.ShowModKey);
			PostShow = new HotKey(ModKey, aps.ShowKeyChar);
			// Event Add
			PostShow.HotKeyPush += new EventHandler(HotPush);
		}

		private void Background_FormClosing(object sender, FormClosingEventArgs e)
		{
			AppSettingAccess.SaveSetting(aps);
			notifyIcon1.Visible = false;
			if(PostShow != null){ PostShow.Dispose(); }
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(stWindow != null)
			{
				// Set Focus
				stWindow.Activate();
			}
			else if(psWindow != null)
			{
				psWindow.Visible = !psWindow.Visible;
				// Set Focus
				psWindow.Activate();
			}
			else
			{
				投稿PToolStripMenuItem_Click(sender, e);
			}
		}

		private void HotPush(object sender, EventArgs e){
			// HotKey
			notifyIcon1_MouseDoubleClick(sender, null);
		}
	}
}
