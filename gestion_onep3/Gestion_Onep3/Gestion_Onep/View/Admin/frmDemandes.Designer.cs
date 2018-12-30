namespace Gestion_Onep.View.Admin
{
    partial class frmDemandes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbAjent = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.lblAgent = new System.Windows.Forms.Label();
            this.demandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idagentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedemandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrjourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precisionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opinionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idagentDataGridViewTextBoxColumn,
            this.datedemandeDataGridViewTextBoxColumn,
            this.duDataGridViewTextBoxColumn,
            this.auDataGridViewTextBoxColumn,
            this.nbrjourDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.precisionsDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.opinionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.demandeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // cmbAjent
            // 
            this.cmbAjent.FormattingEnabled = true;
            this.cmbAjent.Location = new System.Drawing.Point(136, 12);
            this.cmbAjent.Name = "cmbAjent";
            this.cmbAjent.Size = new System.Drawing.Size(425, 21);
            this.cmbAjent.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.Reset);
            this.splitContainer1.Panel1.Controls.Add(this.lblAgent);
            this.splitContainer1.Panel1.Controls.Add(this.cmbAjent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(850, 374);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(734, 10);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(101, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Renitualiser";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(73, 15);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(35, 13);
            this.lblAgent.TabIndex = 2;
            this.lblAgent.Text = "Agent";
            // 
            // demandeBindingSource
            // 
            this.demandeBindingSource.DataSource = typeof(Gestion_Onep.MODEL.Demande);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idagentDataGridViewTextBoxColumn
            // 
            this.idagentDataGridViewTextBoxColumn.DataPropertyName = "id_agent";
            this.idagentDataGridViewTextBoxColumn.HeaderText = "id_agent";
            this.idagentDataGridViewTextBoxColumn.Name = "idagentDataGridViewTextBoxColumn";
            // 
            // datedemandeDataGridViewTextBoxColumn
            // 
            this.datedemandeDataGridViewTextBoxColumn.DataPropertyName = "date_demande";
            this.datedemandeDataGridViewTextBoxColumn.HeaderText = "date_demande";
            this.datedemandeDataGridViewTextBoxColumn.Name = "datedemandeDataGridViewTextBoxColumn";
            // 
            // duDataGridViewTextBoxColumn
            // 
            this.duDataGridViewTextBoxColumn.DataPropertyName = "du";
            this.duDataGridViewTextBoxColumn.HeaderText = "du";
            this.duDataGridViewTextBoxColumn.Name = "duDataGridViewTextBoxColumn";
            // 
            // auDataGridViewTextBoxColumn
            // 
            this.auDataGridViewTextBoxColumn.DataPropertyName = "au";
            this.auDataGridViewTextBoxColumn.HeaderText = "au";
            this.auDataGridViewTextBoxColumn.Name = "auDataGridViewTextBoxColumn";
            // 
            // nbrjourDataGridViewTextBoxColumn
            // 
            this.nbrjourDataGridViewTextBoxColumn.DataPropertyName = "nbrjour";
            this.nbrjourDataGridViewTextBoxColumn.HeaderText = "nbrjour";
            this.nbrjourDataGridViewTextBoxColumn.Name = "nbrjourDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // precisionsDataGridViewTextBoxColumn
            // 
            this.precisionsDataGridViewTextBoxColumn.DataPropertyName = "Precisions";
            this.precisionsDataGridViewTextBoxColumn.HeaderText = "Precisions";
            this.precisionsDataGridViewTextBoxColumn.Name = "precisionsDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Visible = false;
            this.remarkDataGridViewTextBoxColumn.Width = 5;
            // 
            // opinionDataGridViewTextBoxColumn
            // 
            this.opinionDataGridViewTextBoxColumn.DataPropertyName = "opinion";
            this.opinionDataGridViewTextBoxColumn.HeaderText = "opinion";
            this.opinionDataGridViewTextBoxColumn.Name = "opinionDataGridViewTextBoxColumn";
            this.opinionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.opinionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.opinionDataGridViewTextBoxColumn.Width = 50;
            // 
            // frmDemandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 374);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDemandes";
            this.Text = "Liste des congés";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.demandeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbAjent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource demandeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedemandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrjourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precisionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn opinionDataGridViewTextBoxColumn;
    }
}