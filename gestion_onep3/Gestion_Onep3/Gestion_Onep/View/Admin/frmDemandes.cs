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
namespace Gestion_Onep.View.Admin
{
    public partial class frmDemandes : Form
    {
        public frmDemandes()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.DemmandeBL.Instance.GetAllDemande();

            cmbAjent.DisplayMember = "Nom";
            cmbAjent.ValueMember = "id";
            cmbAjent.DataSource = BL.AgentBL.Instance.GetAllAgent();

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

                var dem = dataGridView1.Rows[ee.RowIndex].DataBoundItem as MODEL.Demande;
                if (dem != null)
                {
                    var frm = new Print.DemandeIMP(dem);
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }

            };

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 

            var frm = new Print.DemandeIMP();
            frm.ShowDialog();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.DemmandeBL.Instance.GetAllDemande(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAjent.SelectedIndex != -1 && cmbAjent.SelectedValue != null)
            {
                int idAgent = (int)cmbAjent.SelectedValue;
                dataGridView1.DataSource = BL.DemmandeBL.Instance.GetAllDemande().Where(x => x.id_agent == idAgent).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
