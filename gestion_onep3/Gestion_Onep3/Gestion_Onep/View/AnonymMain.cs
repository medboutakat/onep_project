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
    public partial class AnonymMain : Form
    {
        public AnonymMain()
        {
            InitializeComponent();
        }

      

        private void Main_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += (se, ee) =>
            {
                Application.Exit();
            };
        }
        private void btnProduitsStock_Click(object sender, EventArgs e)
        {
            Hide();
            var Con = new Gestion_Onep.View.Anonym.frmDemande();
            Con.StartPosition = FormStartPosition.CenterParent;
            Con.ShowDialog();
            this.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Hide();
            var Con = new Gestion_Onep.View.Anonym.frmDemande();
            Con.StartPosition = FormStartPosition.CenterParent;
            Con.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            var Con = new Gestion_Onep.View.Anonym.frmDemande();
            Con.StartPosition = FormStartPosition.CenterParent;
            Con.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide();
            //var Con = new UtilisateurFrm();
            //Con.StartPosition = FormStartPosition.CenterParent;
            //Con.ShowDialog();
            //this.Show();
        }

        private void factureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgent.PerformClick();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnService.PerformClick();
        }

        private void voitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDemande.PerformClick();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDemande.PerformClick();
        }

        private void btnMouvementStock_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hide();
            ////var Con = new ReglementFrm();
            //Con.StartPosition = FormStartPosition.CenterParent;
            //Con.ShowDialog();
            //this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Con = new Gestion_Onep.View.Admin.frmService();
            Con.StartPosition = FormStartPosition.CenterParent;
            Con.ShowDialog();
            this.Show();
        }
    }
}
