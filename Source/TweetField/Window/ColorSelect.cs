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
	public partial class ColorSelect : Form
	{
		// Select Color String
		public String ColorStr;

		// Constructor
		public ColorSelect()
		{
			// Init
			InitializeComponent();
			// Load
			LoadAllColor();
		}

		// @load
		private void ColorSelect_Load(object sender, EventArgs e)
		{
			// if color selected
			if(ColorStr != ""){
				// Item Search and Get
				var Item = ColorList.FindItemWithText(ColorStr, true, 0);	
				// if Item is not null
				if(Item != null){
					// Set
					Item.Selected = true;
					Item.Focused = true;
				}
			}
			ColorList.Select();
		}

		// Add All Color
		private void LoadAllColor()
		{
			// List
			var ColorsList = new List<Color>();
			// Clear
			ColorList.Items.Clear();
			// All Adding
			foreach (System.Reflection.PropertyInfo info in 
				typeof(Color).GetProperties(System.Reflection.BindingFlags.Public | 
				System.Reflection.BindingFlags.Static)){
				ColorsList.Add((Color)info.GetValue(null, null));
			}
			// Sort
			ColorsList.Sort(delegate(Color a, Color b){ return (b.R+b.G+b.B)-(a.R+a.G+a.B); });
			// Add ListView
			foreach (var color in ColorsList){
				// if name is Transparent
				if(color.Name == "Transparent"){
					continue;
				}
				// RGB Code
				String RGBCode = "#" + color.R.ToString("X2") + color.G.ToString("X2")
						+color.B.ToString("X2");
				// Create ListItem
				var ListItem = new ListViewItem(new String[]{"", color.Name, RGBCode});
				// Not used parent item's color
				ListItem.UseItemStyleForSubItems = false;
				// Set Background Color
				ListItem.BackColor = color;
				// Add Item
				ColorList.Items.Add(ListItem);
			}
		}

		// Selection Change
		private void ColorList_SelectedIndexChanged(object sender, EventArgs e)
		{
			// if Selected
			if(ColorList.SelectedItems.Count > 0){
				// ColorName Change
				SelectedColorNameEdit.Text = ColorList.SelectedItems[0].SubItems[1].Text;
			}
			// Enable Changed
			OK.Enabled = SelectedColorNameEdit.Text.Length > 0;
		}

		// Button Click
		private void OK_Click(object sender, EventArgs e)
		{
			// ColorName Set
			ColorStr = SelectedColorNameEdit.Text;
			// Result is OK
			DialogResult = DialogResult.OK;
			// Close
			Close();
		}
	}
}
