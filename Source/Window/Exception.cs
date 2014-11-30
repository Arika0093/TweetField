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
	public partial class ExceptionForm : Form
	{
		private Exception Excp;

		public ExceptionForm(Exception Exp)
		{
			Excp = Exp;
			InitializeComponent();
		}

		private void ExceptionForm_Load(object sender, EventArgs e)
		{
			textBox1.Text = Excp.StackTrace;
			textBox2.Text = Excp.Message;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
