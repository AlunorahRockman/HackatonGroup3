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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void nouvProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit fl = new AjouterProduit();
            fl.ShowDialog();
        }

        private void nouvclient_Click(object sender, EventArgs e)
        {
            AjouterClient ajout = new AjouterClient();
            ajout.ShowDialog();
        }

        private void nouvutilis_Click(object sender, EventArgs e)
        {
            AjouterUtilisateur aj = new AjouterUtilisateur();
            aj.ShowDialog();
        }
    }
}
