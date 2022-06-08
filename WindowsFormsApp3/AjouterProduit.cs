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
    public partial class AjouterProduit : Form
    {
        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void engregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputID.Text))
                return;
            if (string.IsNullOrWhiteSpace(inputBarreCode.Text))
                return;
            if (string.IsNullOrWhiteSpace(inputCategory.Text))
                return;
            if (string.IsNullOrWhiteSpace(inputType.Text))
                return;
            if (string.IsNullOrWhiteSpace(inputName.Text))
                return;
            if (string.IsNullOrWhiteSpace(inputprix.Text))
                return;


        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
