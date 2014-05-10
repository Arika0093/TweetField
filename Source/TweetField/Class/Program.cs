using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

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
			// Create Mutex
			Mutex mutex = new Mutex(false, "TweetField");
			// Dual Run Check
			if (mutex.WaitOne(0, false) == false){
				// Show
				MessageBox.Show("既に起動しています。");
				// End
				return;
			}
			Application.ThreadException += Application_ThreadException;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Post());
			// Release Mutex
			mutex.ReleaseMutex();
		}

		public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			// Msg
			new ExceptionForm(e.Exception).Show();
		}
	}
}
