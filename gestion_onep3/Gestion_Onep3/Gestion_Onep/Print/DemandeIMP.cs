using Gestion_Onep.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Onep.Print
{
    public partial class DemandeIMP : Form
    {

        #region Member
        public MODEL.Demande Demande { get; set; }
        #endregion


        public DemandeIMP()
        {
            InitializeComponent();
        }

        public DemandeIMP(MODEL.Demande demmand)
            : this()
        {
            Demande = demmand;


        }

        private void DemandeIMP_Load(object sender, EventArgs e)
        {
             
            rdAcepter.Checked =Demande.opinion!=null&& Convert.ToBoolean(Demande.opinion);
            rdRefeser.Checked = Demande.opinion != null && !rdAcepter.Checked; 
            txtMotif.Text = Demande.Precisions; 

            DemandeBindingSource.DataSource = Demande;// new List<Demande> { Demande }; 
            this.reportViewer1.RefreshReport();
        }

        private void btnApplay_Click(object sender, EventArgs e)
        {
            this.Demande.opinion = Convert.ToByte(rdAcepter.Checked);
            this.Demande.Precisions = txtMotif.Text;
            BL.DemmandeBL.Instance.UpdateDemande(Demande); 
            MessageBox.Show(string.Format("Demande {0} avec success", rdAcepter.Checked?"acçepté":"refusé"));
        }

        private void rdAcepter_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
