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
namespace Gestion_Onep.View.Anonym
{
    public partial class frmDemande : Form
    {
        bool NewObject = false;
        Gestion_Onep.MODEL.Demande curentObject;
        public frmDemande()
        {
            InitializeComponent(); 
            NewObject = true;
            curentObject = new MODEL.Demande();
        }
        public frmDemande( Gestion_Onep.MODEL.Demande  obj):this()
        {
            NewObject = false;
            curentObject = obj;
        }
        protected override void OnLoad(EventArgs e)
        {
            cmb_type.DataSource = BL.TypeCongeBL.Instance.GetAll();
            cmb_type.DisplayMember = "nom";
            cmb_type.ValueMember = "id";
            this.Text = string.Format("{0} {1} du service ", Gestion_OnepAgent.GLOBAL.Global.ConnectedAgent.Nom, Gestion_OnepAgent.GLOBAL.Global.ConnectedAgent.Prenom, Gestion_OnepAgent.GLOBAL.Global.ConnectedAgent.service.Nom);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        { 
            try
            {
                if (curentObject != null)
                {
                    BL.DemmandeBL.Instance.DeleteDemande(curentObject.id); 
                    MessageBox.Show("Bien annulée !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            //btnNew.Enabled = !(NewObject = true);
            curentObject = new MODEL.Demande();
            //txtCin.Text = txtNom.Text = txtAdress.Text = txtTele.Text = ""; 
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curentObject != null)
            {
                int nbrjour;
                curentObject.Precisions = txtprec.Text;
                curentObject.id_agent = Gestion_OnepAgent.GLOBAL.Global.ConnectedAgent.id;

                int.TryParse(txt_nbr.Text, out nbrjour);
                curentObject.nbrjour = nbrjour;
                curentObject.date_demande = dttdem.Value;
                curentObject.du = d_debut.Value;
                curentObject.au = d_retour.Value;


                if (NewObject)
                {
                    BL.DemmandeBL.Instance.AddDemande(curentObject);
                    Close();
                }
                else
                {
                    BL.DemmandeBL.Instance.UpdateDemande(curentObject);
                    Close();
                }
                MessageBox.Show("Agent enregister avec success");
                //btnNew.Enabled = !(NewObject = false);

                Close();

            }
        }

        private void d_retour_ValueChanged(object sender, EventArgs e)
        {
            DateTime d_re = d_retour.Value.Date;
            DateTime d_de = d_debut.Value.Date;
            TimeSpan t = d_de - d_re;
            int days = t.Days;
            txtLabel.Text = days.ToString() + " jour(s)";

        }

        private void frmDemande_Load(object sender, EventArgs e)
        {

        }

        private void txt_idagent_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
