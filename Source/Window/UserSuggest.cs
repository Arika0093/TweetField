using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TweetSharp;

namespace TweetField
{
	public partial class UserSuggest : Form
	{
		private TwitterUser[] Pr;
		private Rectangle Rc;
		private bool PictUsed;
		public List<TwitterUser> Selected = new List<TwitterUser>();
		public int SelectedCount = 0;

		public UserSuggest(TwitterUser[] Pair, Rectangle Rect, bool Pict)
		{
			// Init
			InitializeComponent();
			// Copy
			Pr = Pair;
			Rc = Rect;
			PictUsed = Pict;
			// Set
			UserList.Columns[0].Width = Rect.Size.Width * 6/10;
			UserList.Columns[1].Width = Rect.Size.Width * 3/10;
		}

		private void UserSuggest_Load(object sender, EventArgs e)
		{
			// Window Height
			int SgHeight = 25*8;
			// Move
			Location = new Point(Rc.X,
				(Rc.Y - SgHeight > 0 ? Rc.Y - SgHeight : Rc.Y + Rc.Height));
			Size = new Size(Rc.Width, SgHeight);
			// addition
			var imgconv = new ImageConverter();
			var Wc = new System.Net.WebClient();
			int ct = 0;
			foreach(var Ac in Pr){
				// Add List
				var lvi = new ListViewItem();
				var lvs = new ListViewItem.ListViewSubItem();
				lvi.Text = Ac.Name;
				lvs.Text = Ac.ScreenName;
				lvs.ForeColor = Color.Gray;
				lvi.SubItems.Add(lvs);
				// Image Get
				if(PictUsed){
					UserList.LargeImageList = imageList1;
					UserList.SmallImageList = imageList1;
					var img = (Image)imgconv.ConvertFrom(Wc.DownloadData(Ac.ProfileImageUrl));
					imageList1.Images.Add(img);
					lvi.ImageIndex = ct;
				}
				UserList.Items.Add(lvi);
				ct++;
			}
			Wc.Dispose();
		}

		private void UserList_DoubleClick(object sender, EventArgs e)
		{
			if(UserList.SelectedIndices.Count > 0){
				for(int i=0; i < UserList.SelectedIndices.Count; i++){
					Selected.Add(Pr[UserList.SelectedIndices[i]]);
				}
				SelectedCount = UserList.SelectedIndices.Count;
			}
			Close();
		}

		private void UserList_KeyDown(object sender, KeyEventArgs e)
		{
			// Enter
			if(e.KeyCode == Keys.Enter && UserList.SelectedItems.Count > 0){
				UserList_DoubleClick(sender, null);
				e.SuppressKeyPress = true;
			}
			// Up
			else if(e.KeyCode == Keys.Up && UserList.SelectedItems.Count > 0
				&& UserList.SelectedItems[0].Index == 0){
				// Unselect
				UserList_AllItemUnselect();
				// Focus move
				SearchBox.Select();
			}
			// Esc / Backspace
			else if(e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back){
				Close();
			}
		}

		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			// Select Item change
			if(SearchBox.Text != "" && UserList.Items.Count > 0) {
				var It = UserList.FindItemWithText(SearchBox.Text, true, 0, true);
				if(It != null){
					UserList_AllItemUnselect();
					UserList.TopItem = It;
					It.Selected = true;
				}
			}
		}

		private void SearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			// Enter
			if(e.KeyCode == Keys.Enter && UserList.SelectedItems.Count > 0){
				UserList_DoubleClick(sender, null);
				e.SuppressKeyPress = true;
			}
			// Down
			if(e.KeyCode == Keys.Down){
				if(UserList.SelectedItems.Count == 0 && UserList.Items.Count > 0){
					UserList.Items[0].Selected = true;
				}
				// Focus move
				UserList.Select();
			}
			// Esc / Backspace
			else if(e.KeyCode == Keys.Escape){
				Close();
			}
			else if(e.KeyCode == Keys.Back && SearchBox.Text.Length == 0){
				Close();
			}
		}

		private void UserList_AllItemUnselect()
		{
			foreach(ListViewItem it in UserList.Items)
				it.Selected = false;
		}
	}
}
