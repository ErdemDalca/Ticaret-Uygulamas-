using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ticaret_Uygulaması
{
	internal static class Program
	{
		/// <summary>
		/// Uygulamanın ana girdi noktası.
		/// </summary>
		[STAThread]
		static void Main()
		{
			XmlDocument config = new XmlDocument();
			config.Load("config.xml");

			string Authdomain = config.DocumentElement.SelectSingleNode("/Firebase/AuthDomain").InnerText.Trim();
			string ApiKey = config.DocumentElement.SelectSingleNode("/Firebase/ApiKey").InnerText.Trim();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (Environment.OSVersion.Version.Major >= 6)
				SetProcessDPIAware();
			Application.Run(new BackSpace(Authdomain,ApiKey));
			
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
