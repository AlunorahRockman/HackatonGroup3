using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Client
    {

        public int clientId { get; set; }
        public string clientNames { get; set; }
        public string clientAdresse { get; set; }
        public string clientTel { get; set; }
        public int Sexe { get; set; }


        public Client(int clientId, string clientNames, string clientAdresse, string clientTel, int sexe)
        {
            this.clientId = clientId;
            this.clientNames = clientNames;
            this.clientAdresse = clientAdresse;
            this.clientTel = clientTel;
            Sexe = sexe;
        }

        public Client()
        {

        }


    }
}
