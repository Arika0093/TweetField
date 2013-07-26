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
	public partial class HotKeyEdit : Form
	{
		// Push Key
		public Keys PushKey = Keys.Space;

		// Constructor
		public HotKeyEdit()
		{
			InitializeComponent();
		}

		// Set Hotkey
		public String SetHotKey(ref Keys Key, ref int Mod, Form fm)
		{
			// Checked Change
			checkBox1.Checked	= ((Mod & (int)MOD_KEY.CONTROL) != 0);
			checkBox2.Checked	= ((Mod & (int)MOD_KEY.SHIFT) != 0);
			checkBox3.Checked	= ((Mod & (int)MOD_KEY.ALT) != 0);
			textBox1.Text		= Key.ToString();
			PushKey				= Key;
			// Show Dialog
			if(ShowDialog(fm) == DialogResult.OK){
				Key = Keys.None;
				Mod = 0;
				// Set Key
				Key = PushKey;
				// Mod Check
				Mod += (checkBox1.Checked ? (int)MOD_KEY.CONTROL : 0);
				Mod += (checkBox2.Checked ? (int)MOD_KEY.SHIFT : 0);
				Mod += (checkBox3.Checked ? (int)MOD_KEY.ALT : 0);
			}
			// Get String
			return HotKey.GetKeyString(Key, Mod);
		}

		// Key Down
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(!e.Shift && !e.Control && !e.Alt){
				// Text Change
				textBox1.Text = e.KeyCode.ToString();
				PushKey = e.KeyCode;
			}
			// End
			e.SuppressKeyPress = true;
		}

		// OK
		private void button1_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		// Cancel
		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

	}
}
