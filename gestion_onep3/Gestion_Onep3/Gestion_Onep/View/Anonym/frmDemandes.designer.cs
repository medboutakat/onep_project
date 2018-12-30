namespace Gestion_OnepAgent.View.Anonym
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
            this.demandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(795, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            this.remarkDataGridViewTextBoxColumn.HeaderText = "remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // opinionDataGridViewTextBoxColumn
            // 
            this.opinionDataGridViewTextBoxColumn.DataPropertyName = "opinion";
            this.opinionDataGridViewTextBoxColumn.HeaderText = "opinion";
            this.opinionDataGridViewTextBoxColumn.Name = "opinionDataGridViewTextBoxColumn";
            this.opinionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.opinionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // demandeBindingSource
            // 
            this.demandeBindingSource.DataSource = typeof(Gestion_Onep.MODEL.Demande);
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
            this.splitContainer1.Panel1.Controls.Add(this.Reset);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(795, 374);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 2;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(634, 12);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(149, 57);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Nouvelle demmande";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // frmDemandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 374);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDemandes";
            this.Text = "Liste des congés";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Reset;
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
        private System.Windows.Forms.BindingSource demandeBindingSource;
    }
}