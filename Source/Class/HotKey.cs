﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// ----------------------------------------------
//	From: http://anis774.net/codevault/00140.html
// ----------------------------------------------
namespace TweetField
{
	/// <summary>
	/// グローバルホットキーを登録するクラス。
	/// 使用後は必ずDisposeすること。
	/// </summary>
	public class HotKey : IDisposable
	{
		HotKeyForm form;
		/// <summary>
		/// ホットキーが押されると発生する。
		/// </summary>
		public event EventHandler HotKeyPush;

		/// <summary>
		/// ホットキーを指定して初期化する。
		/// 使用後は必ずDisposeすること。
		/// </summary>
		/// <param name="modKey">修飾キー</param>
		/// <param name="key">キー</param>
		public HotKey(MOD_KEY modKey, Keys key)
		{
			form = new HotKeyForm(modKey, key, raiseHotKeyPush);
		}

		private void raiseHotKeyPush()
		{
			if (HotKeyPush != null)
			{
				HotKeyPush(this, EventArgs.Empty);
			}
		}

		public void Dispose()
		{
			form.Dispose();
		}

		private class HotKeyForm : Form
		{
			[DllImport("user32.dll")]
			extern static int RegisterHotKey(IntPtr HWnd, int ID, MOD_KEY MOD_KEY, Keys KEY);

			[DllImport("user32.dll")]
			extern static int UnregisterHotKey(IntPtr HWnd, int ID);

			const int WM_HOTKEY = 0x0312;
			int id;
			ThreadStart proc;

			public HotKeyForm(MOD_KEY modKey, Keys key, ThreadStart proc)
			{
				this.proc = proc;
				for (int i = 0x0000; i <= 0xbfff; i++)
				{
					if (RegisterHotKey(this.Handle, i, modKey, key) != 0)
					{
						id = i;
						break;
					}
				}
			}

			protected override void WndProc(ref Message m)
			{
				base.WndProc(ref m);

				if (m.Msg == WM_HOTKEY)
				{
					if ((int)m.WParam == id)
					{
						proc();
					}
				}
			}

			protected override void Dispose(bool disposing)
			{
				UnregisterHotKey(this.Handle, id);
				base.Dispose(disposing);
			}
		}

		// Get HotKey String
		public static String GetKeyString(Keys Key, int Mod)
		{
			// String
			String Result = "";
			// Sub Key 
			Result += ((Mod & (int)MOD_KEY.CONTROL) != 0 ? "Ctrl + " : "");
			Result += ((Mod & (int)MOD_KEY.SHIFT) != 0 ? "Shift + " : "");
			Result += ((Mod & (int)MOD_KEY.ALT) != 0 ? "Alt + " : "");
			Result += Key.ToString();
			return Result;
		}

	}

	/// <summary>
	/// HotKeyクラスの初期化時に指定する修飾キー
	/// </summary>
	public enum MOD_KEY : int
	{
		ALT = 0x0001,
		CONTROL = 0x0002,
		SHIFT = 0x0004,
	}
}