using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticaret_Uygulaması.Sınıflar
{
	public class OfferWithImage
	{
		public Offer offer;
		public Bitmap ımage;
		public string Uıd;

		public OfferWithImage(Offer offer, Bitmap ımage, string Uıd="")
		{
			this.offer = offer;
			this.ımage = ımage;
			this.Uıd = Uıd;
		}
	}
}
