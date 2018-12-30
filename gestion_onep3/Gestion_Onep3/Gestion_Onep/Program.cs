using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gestion_Onep
{
    static class Program
    {
        public static SqlConnection Ocon = new SqlConnection("Data source=localhost;initial catalog=gestion_agent;integrated security=SSPI");
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gestion_Onep.View.LoginFrm());
        }
    }
}
