using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticaret_Uygulaması.Sınıflar
{
	public class Ayarlar
	{
		public string AuthDomain;
		public string ApiKey;
		public string FDDomain;
		public string FSDomain;

		public Ayarlar(string AuthDomain, string ApiKey, string FDDomain, string FSDomain)
		{
			this.AuthDomain = AuthDomain;
			this.ApiKey = ApiKey;
			this.FDDomain = FDDomain;
			this.FSDomain = FSDomain;
		}
	}
}
