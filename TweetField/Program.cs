using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
			// Create Mutex
			Mutex mutex = new Mutex(false, "TweetField");
			// Dual Run Check
			if (mutex.WaitOne(0, false) == false){
				// Show
				MessageBox.Show("既に起動しています。");
				// End
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Background());
			// Release Mutex
			mutex.ReleaseMutex();
		}
	}
}
