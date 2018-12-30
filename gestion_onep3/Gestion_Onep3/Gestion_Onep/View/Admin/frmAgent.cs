using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace Gestion_Onep.View.Admin
{ 
    public partial class frmAgent : Form
    {
        bool NewObject = false;
        MODEL.agent curentObject;
        public frmAgent()
        {
            InitializeComponent();

            cmbService.DataSource = BL.ServiceBL.Instance.GetAll();
            cmbService.ValueMember = "Id";
            cmbService.DisplayMember = "Nom";

            

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
          
            dataGridView1.SelectionChanged += (e, ee) =>
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    curentObject = (dataGridView1.SelectedRows[0].DataBoundItem as MODEL.agent);
                    txtCin.Text = curentObject.CIN;
                    txtNom.Text = curentObject.Nom;
                    cmbService.SelectedValue = curentObject.Service_Id;
                   // txtTele.Text = curentObject.Tel;
                    txtfonction.Text = curentObject.Fonction;
                    txtAdress.Text = curentObject.UserName;
                    txtprenom.Text = curentObject.Prenom;

                }

            };
        }
        protected override void OnLoad(EventArgs e)
        {
            dataGridView1.DataSource = BL.AgentBL.Instance.GetAllAgent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
 

        private void button2_Click(object sender, EventArgs e)
        {
            if (curentObject != null)
            {
                curentObject.CIN = txtCin.Text;
                curentObject.Nom = txtNom.Text;
                //curentObject.Serice_agent = txtTele.Text;
                curentObject.UserName = txtAdress.Text; 
                //curentObject.Tel = txtNom.Text;
                //curentObject.datenaissance = dtNaissance.Value;
                if (NewObject)
                {
                    BL.AgentBL.Instance.AddAgent(curentObject);
                }
                else
                {
                    BL.AgentBL.Instance.UpdateAgent(curentObject);
                }
                MessageBox.Show("Agent enregister avec success");
                btnNew.Enabled = !(NewObject = false);
                dataGridView1.DataSource = BL.AgentBL.Instance.GetAllAgent();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (curentObject != null)
                {
                    BL.AgentBL.Instance.DeleteAgent(curentObject.id);
                    dataGridView1.DataSource = BL.AgentBL.Instance.GetAllAgent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Agent déjà utilisé");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.AgentBL.Instance.GetAllAgent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = !(NewObject = true);
            curentObject = new MODEL.agent();
            txtCin.Text = txtNom.Text = txtAdress.Text = txtTele.Text = "";

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
