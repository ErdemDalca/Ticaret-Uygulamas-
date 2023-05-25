using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticaret_Uygulaması
{
	public partial class kullaniciBilgileriUC : UserControl
	{
		UserCredential userCredential;
		
        public kullaniciBilgileriUC(UserCredential userCredential)
		{
		
			InitializeComponent();
			this.userCredential = userCredential;

		}

		public void kullaniciBilgileriUC_Load(object sender, EventArgs e)
		{
			
			
			
		}

        private void aciklamaLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
