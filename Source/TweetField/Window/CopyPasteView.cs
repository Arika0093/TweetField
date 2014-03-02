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
	public partial class CopyPasteView : Form
	{
		private ApplicationSetting As;

		private String SelectString;

		private List<CopyWords> CwList;

		public String CallString;

		public CopyPasteView(ref ApplicationSetting Aps, String Select)
		{
			// Init
			InitializeComponent();
			// Copy
			As = Aps;
			SelectString = Select;
			CwList = As.CopyPasteWords.ToList();
			// Add Item
			foreach(var Item in CwList){
				// Add List
				listBox1.Items.Add(Item.ShortText);
				// Select Index
				listBox1.SelectedIndex = 0;
			}
			// Set
			CallString = "";
		}

		// Select Changed
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Enable Change
			Call.Enabled = (listBox1.SelectedIndex >= 0);
			button2.Enabled = (listBox1.SelectedIndex >= 0);
			button3.Enabled = (listBox1.SelectedIndex >= 0);
		}

		// Call
		private void Call_Click(object sender, EventArgs e)
		{
			// Saved
			As.CopyPasteWords = CwList;
			// Call
			CallString = CwList[listBox1.SelectedIndex].GetString(SelectString);
			// Close
			Close();
		}

		// New
		private void button1_Click(object sender, EventArgs e)
		{
			// CopyPaste Word for Ref
			var Cws = new CopyWords();
			// Default Value Set
			Cws.ShortText = "";
			Cws.Text = "";
			Cws.IsMenuShow = true;
			Cws.IsRandomize = false;
			// Create Instance
			var Dlg = new CopyPasteWordEditer(ref Cws);
			// Dialog Show
			Dlg.ShowDialog();
			// if result is cancel
			if(Dlg.DialogResult == DialogResult.Cancel){
				// End
				return;
			}
			// Add List
			CwList.Add(Cws);
			// Add ListView
			listBox1.Items.Add(Cws.ShortText);
		}

		// Edit
		private void button2_Click(object sender, EventArgs e)
		{
			// Edit Target Index
			var SlcIndex = listBox1.SelectedIndex;
			// CopyPaste Word for Ref
			var Cws = CwList[SlcIndex];
			// Create Instance
			var Dlg = new CopyPasteWordEditer(ref Cws);
			// Dialog Show
			Dlg.ShowDialog();
			// if result is cancel
			if(Dlg.DialogResult == DialogResult.Cancel){
				// End
				return;
			}
			// Canged
			CwList[SlcIndex] = Cws;
			// Remove Target
			listBox1.Items.RemoveAt(SlcIndex);
			// Insert Item
			listBox1.Items.Insert(SlcIndex, Cws.ShortText);
		}

		// Delete
		private void button3_Click(object sender, EventArgs e)
		{
			// Edit Target Index
			var SlcIndex = listBox1.SelectedIndex;
			// Deleted
			CwList.RemoveAt(SlcIndex);
			// Remove Target
			listBox1.Items.RemoveAt(SlcIndex);
		}

		// OK
		private void button4_Click(object sender, EventArgs e)
		{
			// Saved
			As.CopyPasteWords = CwList;
			// Close
			Close();
		}

		// Cancel
		private void button5_Click(object sender, EventArgs e)
		{
			// Close
			Close();
		}
	}
}
