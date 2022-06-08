using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Utilisateur
    {
 

        public int userId { get; set; }
        public string motdepasseutilisateur { get; set; }
        public string userNames { get; set; }
        public string userAdresse { get; set; }
        public string userTel { get; set; }
        public int Permission { get; set; }

        public Utilisateur()
        {

        }

        public Utilisateur(int userId, string motdepasseutilisateur, string userNames, string userAdresse, string userTel, int permission)
        {
            this.userId = userId;
            this.motdepasseutilisateur = motdepasseutilisateur;
            this.userNames = userNames;
            this.userAdresse = userAdresse;
            this.userTel = userTel;
            Permission = permission;
        }
    }
}
