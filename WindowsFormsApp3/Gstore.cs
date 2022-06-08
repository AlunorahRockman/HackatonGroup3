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
    public partial class Gstore : Form
    {
        public Gstore()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            LoginAdmin un = new LoginAdmin();
            un.Show();
        }

        private void Employ_Click(object sender, EventArgs e)
        {
            LoginEmploye un = new LoginEmploye();
            un.ShowDialog();
        }
    }
}
