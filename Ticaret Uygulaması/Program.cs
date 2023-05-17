using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Ticaret_Uygulaması.Sınıflar;

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
			string FDDomain = config.DocumentElement.SelectSingleNode("/Firebase/FDDomain").InnerText.Trim();
			string FSDomain = config.DocumentElement.SelectSingleNode("/Firebase/FSDomain").InnerText.Trim();

			Ayarlar ayarlar = new Ayarlar(Authdomain,ApiKey,FDDomain,FSDomain); 

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (Environment.OSVersion.Version.Major >= 6)
				SetProcessDPIAware();
			Application.Run(new BackSpace(ayarlar));
			
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
