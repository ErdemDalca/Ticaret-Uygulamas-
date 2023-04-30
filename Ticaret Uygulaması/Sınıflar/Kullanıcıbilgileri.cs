using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticaret_Uygulaması.Sınıflar
{
    public class Kullanıcıbilgileri
    {
        public string UID = "0";
        public string Name = "";
        public string Description = "0";
        public string lastname ="0";

        public Kullanıcıbilgileri(string UID,string Name, string Description, string Lastname) 
        {
            this.UID = UID;
            this.Name = Name; 
            this.Description = Description;
            this.lastname = Lastname;
        }
        
    }
}
