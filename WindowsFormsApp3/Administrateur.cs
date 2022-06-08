using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Administrateur
    {
        public int adminId { get; set; }
        public string adminMotdepasse { get; set; }
        public string adminmotdepassestring { get; set; }
        public string adminNames { get; set; }
        public string adminAdresse { get; set; }
        public string adminTel { get; set; }
    

        public Administrateur()
        {

        }

        public Administrateur(int adminId, string adminMotdepasse, string adminNames, string adminAdresse, string adminTel)
        {
            this.adminId = adminId;
            this.adminMotdepasse = adminMotdepasse;
            this.adminNames = adminNames;
            this.adminAdresse = adminAdresse;
            this.adminTel = adminTel;
        }
    }
}
