namespace Gestion_Onep.Print
{
    partial class DemandeIMP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DemandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnApplay = new System.Windows.Forms.Button();
            this.rdAcepter = new System.Windows.Forms.RadioButton();
            this.rdRefeser = new System.Windows.Forms.RadioButton();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DemandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DemandeBindingSource
            // 
            this.DemandeBindingSource.DataSource = typeof(Gestion_Onep.MODEL.Demande);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DemandeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_Onep.Report.Demande.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 115);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(742, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnApplay
            // 
            this.btnApplay.Location = new System.Drawing.Point(640, 56);
            this.btnApplay.Name = "btnApplay";
            this.btnApplay.Size = new System.Drawing.Size(75, 23);
            this.btnApplay.TabIndex = 1;
            this.btnApplay.Text = "Appliquer";
            this.btnApplay.UseVisualStyleBackColor = true;
            this.btnApplay.Click += new System.EventHandler(this.btnApplay_Click);
            // 
            // rdAcepter
            // 
            this.rdAcepter.AutoSize = true;
            this.rdAcepter.Location = new System.Drawing.Point(640, 10);
            this.rdAcepter.Name = "rdAcepter";
            this.rdAcepter.Size = new System.Drawing.Size(68, 17);
            this.rdAcepter.TabIndex = 2;
            this.rdAcepter.TabStop = true;
            this.rdAcepter.Text = "Accepter";
            this.rdAcepter.UseVisualStyleBackColor = true;
            this.rdAcepter.CheckedChanged += new System.EventHandler(this.rdAcepter_CheckedChanged);
            // 
            // rdRefeser
            // 
            this.rdRefeser.AutoSize = true;
            this.rdRefeser.Location = new System.Drawing.Point(640, 33);
            this.rdRefeser.Name = "rdRefeser";
            this.rdRefeser.Size = new System.Drawing.Size(62, 17);
            this.rdRefeser.TabIndex = 3;
            this.rdRefeser.TabStop = true;
            this.rdRefeser.Text = "Refeser";
            this.rdRefeser.UseVisualStyleBackColor = true;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(49, 10);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(578, 69);
            this.txtMotif.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Motif";
            // 
            // DemandeIMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.rdRefeser);
            this.Controls.Add(this.rdAcepter);
            this.Controls.Add(this.btnApplay);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DemandeIMP";
            this.Text = "DemandeIMP";
            this.Load += new System.EventHandler(this.DemandeIMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DemandeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnApplay;
        private System.Windows.Forms.RadioButton rdAcepter;
        private System.Windows.Forms.RadioButton rdRefeser;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource DemandeBindingSource;
    }
}