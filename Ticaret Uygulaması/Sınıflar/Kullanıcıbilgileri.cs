using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticaret_Uygulaması.Sınıflar
{
	public class Kullanıcıbilgileri
	{
		public string UID { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Description { get; set; }
		public List<Offer> OfferList
		{
			get { return _offerList; }
			set { _offerList = value; }
		}

		public List<Offer> _offerList = new List<Offer>();
		
		public Kullanıcıbilgileri(string UID, string Name, string Description, string Lastname)
		{
			this.UID = UID;
			this.Name = Name;
			this.Description = Description;
			this.Lastname = Lastname;
		}
	}
}
