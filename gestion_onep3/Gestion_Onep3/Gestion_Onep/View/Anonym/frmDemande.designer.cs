namespace Gestion_Onep.View.Anonym
{
    partial class frmDemande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nbr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dttdem = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.d_retour = new System.Windows.Forms.DateTimePicker();
            this.d_debut = new System.Windows.Forms.DateTimePicker();
            this.txtLabel = new System.Windows.Forms.Label();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idagent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(436, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(88, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 46);
            this.button1.TabIndex = 50;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nbr
            // 
            this.txt_nbr.Location = new System.Drawing.Point(176, 559);
            this.txt_nbr.Name = "txt_nbr";
            this.txt_nbr.Size = new System.Drawing.Size(200, 20);
            this.txt_nbr.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "nbr_jour";
            // 
            // txtprec
            // 
            this.txtprec.Location = new System.Drawing.Point(181, 233);
            this.txtprec.Multiline = true;
            this.txtprec.Name = "txtprec";
            this.txtprec.Size = new System.Drawing.Size(367, 99);
            this.txtprec.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Précisions";
            // 
            // dttdem
            // 
            this.dttdem.Location = new System.Drawing.Point(181, 57);
            this.dttdem.Name = "dttdem";
            this.dttdem.Size = new System.Drawing.Size(367, 20);
            this.dttdem.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Date demande";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(181, 195);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(367, 21);
            this.cmb_type.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Type de conge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Au";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Du";
            // 
            // d_retour
            // 
            this.d_retour.Location = new System.Drawing.Point(181, 102);
            this.d_retour.Name = "d_retour";
            this.d_retour.Size = new System.Drawing.Size(367, 20);
            this.d_retour.TabIndex = 37;
            this.d_retour.ValueChanged += new System.EventHandler(this.d_retour_ValueChanged);
            // 
            // d_debut
            // 
            this.d_debut.Location = new System.Drawing.Point(181, 135);
            this.d_debut.Name = "d_debut";
            this.d_debut.Size = new System.Drawing.Size(367, 20);
            this.d_debut.TabIndex = 36;
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(178, 164);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(44, 13);
            this.txtLabel.TabIndex = 51;
            this.txtLabel.Text = "0 jour(s)";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(Gestion_Onep.MODEL.agent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID_agent";
            // 
            // txt_idagent
            // 
            this.txt_idagent.Location = new System.Drawing.Point(181, 24);
            this.txt_idagent.Name = "txt_idagent";
            this.txt_idagent.Size = new System.Drawing.Size(367, 20);
            this.txt_idagent.TabIndex = 53;
            this.txt_idagent.TextChanged += new System.EventHandler(this.txt_idagent_TextChanged);
            // 
            // frmDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 418);
            this.Controls.Add(this.txt_idagent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nbr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dttdem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.d_retour);
            this.Controls.Add(this.d_debut);
            this.Controls.Add(this.button3);
            this.Name = "frmDemande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDemande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcompletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lccommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sericeagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonctionagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_nbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dttdem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker d_retour;
        private System.Windows.Forms.DateTimePicker d_debut;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idagent;
    }
}

