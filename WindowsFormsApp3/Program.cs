using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Administrateur io = new Administrateur();
            io.adminMotdepasse = "0207";
            io.adminNames = "Ramiadamanana Tody";
            io.adminAdresse = "Vohitsoa";
            io.adminTel = "034 22 569 58";
            Data.GetListAdmin().Add(io);*/
            Application.Run(new Gstore());
        }
    }
}
