using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gestion_Onep.View.Anonym;
namespace Gestion_OnepAgent.View.Anonym
{
    public partial class frmDemandes : Form
    {
        public frmDemandes()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        { 
            dataGridView1.DataSource = Gestion_Onep.BL.DemmandeBL.Instance.GetAllDemande().Where(x => x.id_agent == GLOBAL.Global.ConnectedAgent.id).ToList();
            this.Text = string.Format("{0} {1} du service ", GLOBAL.Global.ConnectedAgent.Nom, GLOBAL.Global.ConnectedAgent.Prenom, GLOBAL.Global.ConnectedAgent.service.Nom);

         

            dataGridView1.CellDoubleClick -= dataGridView1_CellDoubleClick;

            //cmbAjent.SelectedValueChanged += (ss, ee) =>
            //{
            //    if (cmbAjent.SelectedIndex != -1 && cmbAjent.SelectedValue != null)
            //    {
            //        int idAgent = (int)cmbAjent.SelectedValue;
            //        dataGridView1.DataSource = BL.DemmandeBL.Instance.GetAllDemande().Where(x => x.id_agent == idAgent).ToList();
            //    }
            //};

            dataGridView1.CellDoubleClick += (ss, ee) =>
            { 
                var dem = dataGridView1.Rows[ee.RowIndex].DataBoundItem as Gestion_Onep.MODEL.Demande;
                if (dem != null)
                {
                    var frm = new frmDemande(dem);
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                    dataGridView1.DataSource = Gestion_Onep.BL.DemmandeBL.Instance.GetAllDemande().Where(x => x.id_agent == GLOBAL.Global.ConnectedAgent.id).ToList();

                } 
            };


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 

            var frm = new Gestion_Onep.Print.DemandeIMP();
            frm.ShowDialog();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var frm = new Gestion_Onep.View.Anonym.frmDemande();
            frm.ShowDialog();
            dataGridView1.DataSource = Gestion_Onep.BL.DemmandeBL.Instance.GetAllDemande().Where(x => x.id_agent == GLOBAL.Global.ConnectedAgent.id).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


    }
}
