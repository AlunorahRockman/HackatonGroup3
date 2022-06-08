using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Fournisseur
    {


        public int vendorId { get; set; }
        public string vendorCompanyName { get; set; }
        public string vendorTel { get; set; }
        public string vendorAdresse { get; set; }

        public Fournisseur(int vendorId, string vendorCompanyName, string vendorTel, string vendorAdresse)
        {
            this.vendorId = vendorId;
            this.vendorCompanyName = vendorCompanyName;
            this.vendorTel = vendorTel;
            this.vendorAdresse = vendorAdresse;
        }
        public Fournisseur()
        {

        }
    }
}
