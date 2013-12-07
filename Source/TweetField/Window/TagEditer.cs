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
	public partial class TagEditer : Form
	{
		private List<string> Items = new List<string>();
		private ApplicationSetting Aps;

		// Constructor
		public TagEditer(ref ApplicationSetting As)
		{
			// Init
			InitializeComponent();
			// Set Item
			Aps = As;
			// Append
			foreach(var Str in As.HashTagList){
				// Add
				listBox1.Items.Add(Str);
			}
			// Copy
			Items = new List<string>(As.HashTagList);
			// Text Change
			label1.Text = "現在のタグ文字数: " + GetTagStringLenght().ToString();
		}

		// Get Tag Lenght
		private int GetTagStringLenght()
		{
			int Result = 0;
			foreach(var Str in Items){
				Result += Str.Length + 1;
			}
			return Result;
		}

		// Select Change
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Enable
			button2.Enabled = (listBox1.SelectedIndex >= 0);
		}

		// Text Input
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			// If Text isnot Empty
			if(textBox1.Text != ""){
				button1.Enabled = true;
			} else {
				button1.Enabled = false;
			}
		}

		// Add List
		private void button1_Click(object sender, EventArgs e)
		{
			// Split Text
			String[] SplitTag = textBox1.Text.Split(
				new char[]{' ', ',', '.', '#', '-', ';'}, StringSplitOptions.RemoveEmptyEntries);
			// Foreach
			foreach(var Str in SplitTag){
				// Add Item
				listBox1.Items.Add("#" + Str);
				Items.Add("#" + Str);
				// Clear Text
				textBox1.Clear();
				// Text Change
				label1.Text = "現在のタグ文字数: " + GetTagStringLenght().ToString();
			}
		}

		// Delete Item
		private void button2_Click(object sender, EventArgs e)
		{
			// Remove Item
			int Selected = listBox1.SelectedIndex;
			Items.Remove((String)listBox1.Items[Selected]);
			listBox1.Items.RemoveAt(Selected);
			listBox1.SelectedIndex = Selected-1;
			// Text Change
			label1.Text = "現在のタグ文字数: " + GetTagStringLenght().ToString();
		}

		// Accept
		private void button3_Click(object sender, EventArgs e)
		{
			// Equal
			Aps.HashTagList = Items;
			// Close
			Close();
		}
	}
}
