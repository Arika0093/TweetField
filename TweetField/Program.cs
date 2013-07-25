using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TweetField
{
	static class Program
	{
		/// <summary>
		/// Main Entry Point.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Background());
		}
	}
}
