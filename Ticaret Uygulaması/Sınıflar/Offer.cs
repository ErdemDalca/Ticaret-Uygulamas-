using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticaret_Uygulaması.Sınıflar
{
	public class Offer
	{
		public string offerId = "0";
		public string resimUrl ;
		public string açıklama = "0";
		public string fiyat;

		public Offer(string açıklama = "Null", string fiyat="null", string offerId = "Null",string resimUrl = "")
		{
			this.offerId = offerId;
			this.açıklama = açıklama;
			this.fiyat = fiyat;
			this.resimUrl = resimUrl;
		}
	}

	
}
