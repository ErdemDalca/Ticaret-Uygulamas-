using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticaret_Uygulaması
{
	public partial class YüklemeEkranı : Form
	{
		public YüklemeEkranı()
		{
			InitializeComponent();
			List<string> list = new List<string>();
			list.Add("Kağanın Göbeği 120 inch tir");
			list.Add("Emin, Muhammed isminin kullanılmasından hoşlanmaz");
			list.Add("Selim aslında spora gitmiyor");
			list.Add("kağan aslında portekize kaçak yaşamaya gidiyor");
			list.Add("erdemin ailesi, erdemin chp'ye oy attığını bilmiyor");
			list.Add("erdem aslında cahilin teki");

            Random rastgele = new Random();
			int index = rastgele.Next(list.Count); 
			string veri = list[index];

			OrtaYazı.Text = veri;

		}
	}
}
