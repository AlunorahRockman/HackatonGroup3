using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class LoginEmploye : Form
    {
        public LoginEmploye()
        {
            InitializeComponent();
        }
        public static Utilisateur recherche(int id)
        {
            var admin = Data.GetListUser().FirstOrDefault(a => a.userId == id);
            return admin;
        }
        public static Utilisateur recherchers(String mot)
        {
            var admin = Data.GetListUser().FirstOrDefault(a => a.motdepasseutilisateur == mot);
            return admin;
        }

        private void entrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idmamp.Text))
                return;
            if (string.IsNullOrWhiteSpace(motdepassemamp.Text))
                return;
            int id = int.Parse(idmamp.Text);
            Utilisateur admin = recherche(id);
            if (admin == null)
            {
                MessageBox.Show("Utilisateur n'existe pas");
            }
            else
            {
                //bool result = CryptControl.Verify(motdepassemamp.Text, admin.adminMotdepasse);
                Utilisateur adm = recherchers(motdepassemamp.Text);
                if (adm != null)
                {
                    UtilisateurForm form = new UtilisateurForm();
                    form.ShowDialog();
                    this.Hide();
                  
                }
                else
                {
                    MessageBox.Show("Verifier votre mot de passe");
                }
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
