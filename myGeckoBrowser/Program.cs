using System;
using System.IO;
using System.Windows.Forms;
using Gecko;

namespace myGeckoBrowser
{
	static class myGeckoBrowser
	{
		[STAThread]
		static void Main()
		{
			/*string xulRunnerLocation = XULRunnerLocator.GetXULRunnerLocation();
			if (String.IsNullOrEmpty(xulRunnerLocation))
				throw new ApplicationException("The XULRunner library is missing or has the wrong version");
			string librarySearchPath = Environment.GetEnvironmentVariable("LD_LIBRARY_PATH") ?? String.Empty;
			if (!librarySearchPath.Contains(xulRunnerLocation))
				throw new ApplicationException("LD_LIBRARY_PATH must contain " + xulRunnerLocation); */

			Xpcom.Initialize (@"/Library/Frameworks/XUL.framework/Versions/Current");

			var form = new Form();
			var myBrowser = new GeckoWebBrowser {Dock = DockStyle.Fill};
			myBrowser.Navigate("https://duckduckgo.com/");
			form.Controls.Add(myBrowser);
			Application.Run(form);
		}
	}
}
