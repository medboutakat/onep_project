
using Gestion_OnepAgent.View.Anonym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Onep.View
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //MessageBox.Show("Test" + users.Count);
            //testaEntities1 f = new testaEntities1(); 
            //f.user.Add(new user { Id = 1, password = "123", username = "Soumia" });
            //f.user.Add(new user { Id = 2, password = "1234", username = "Med" });
            //f.SaveChanges();
            var user = Gestion_Onep.BL.AgentBL.Instance.getCredencial(txtUserName.Text, txtPassWord.Text);

            if (user != null)
            {
                Gestion_OnepAgent.GLOBAL.Global.ConnectedAgent = user;
                Form frm = null;
                if (Gestion_OnepAgent.GLOBAL.Global.ConnectedAgent.IsAdmin) frm = new AdminMain();
                else frm = new frmDemandes();

                 

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mot de pass ou l'utilisateur incorect!");
            }
        }
    }
}
