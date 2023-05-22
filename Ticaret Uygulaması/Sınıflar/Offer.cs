using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticaret_Uygulaması.Sınıflar
{
	public class Offer
	{
		public string offerId = "0";
		public string resim = "0";
		public string açıklama = "0";
		public string fiyat = "0";

		public Offer(string açıklama = "Null", string fiyat = "Null", string offerId = "Null", string resim = "Null")
		{
			this.offerId = offerId;
			this.resim = resim;
			this.açıklama = açıklama;
			this.fiyat = fiyat;
			
		}
	}

	
}
