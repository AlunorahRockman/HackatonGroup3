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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }
        public static Administrateur recherche(int id)
        {
            var admin = Data.GetListAdmin().FirstOrDefault(a => a.adminId == id);
            return admin;
        }
        public static Administrateur recherchers(String mot)
        {
            var admin = Data.GetListAdmin().FirstOrDefault(a => a.adminMotdepasse == mot);
            return admin;
        }
        private void entrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idmamp.Text))
                return;
            if(string.IsNullOrWhiteSpace(motdepassemamp.Text))
                return;
            int id = int.Parse(idmamp.Text);
            Administrateur admin = recherche(id);
            if (admin == null)
            {
                MessageBox.Show("Administrateur n'existe pas");
            }
            else
            {
                //bool result = CryptControl.Verify(motdepassemamp.Text, admin.adminMotdepasse);
                Administrateur adm = recherchers(motdepassemamp.Text);
                if (adm!=null)
                {
                    AdminForm form = new AdminForm();
                    form.Show();
                    this.Close();

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
