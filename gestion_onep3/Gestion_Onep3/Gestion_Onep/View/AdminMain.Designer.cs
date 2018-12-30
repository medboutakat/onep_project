namespace Gestion_Onep.View
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.factureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDeCongéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCongeType = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnDemande = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factureToolStripMenuItem,
            this.voitureToolStripMenuItem,
            this.utilisateurToolStripMenuItem,
            this.typeDeCongéToolStripMenuItem,
            this.roleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // factureToolStripMenuItem
            // 
            this.factureToolStripMenuItem.Name = "factureToolStripMenuItem";
            this.factureToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.factureToolStripMenuItem.Text = "Agent";
            this.factureToolStripMenuItem.Click += new System.EventHandler(this.factureToolStripMenuItem_Click);
            // 
            // voitureToolStripMenuItem
            // 
            this.voitureToolStripMenuItem.Name = "voitureToolStripMenuItem";
            this.voitureToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.voitureToolStripMenuItem.Text = "Demande";
            this.voitureToolStripMenuItem.Click += new System.EventHandler(this.voitureToolStripMenuItem_Click);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.utilisateurToolStripMenuItem.Text = "Service";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // typeDeCongéToolStripMenuItem
            // 
            this.typeDeCongéToolStripMenuItem.Name = "typeDeCongéToolStripMenuItem";
            this.typeDeCongéToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.typeDeCongéToolStripMenuItem.Text = "Type de congé";
            this.typeDeCongéToolStripMenuItem.Click += new System.EventHandler(this.typeDeCongéToolStripMenuItem_Click);
            // 
            // btnCongeType
            // 
            this.btnCongeType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCongeType.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCongeType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCongeType.BackgroundImage")));
            this.btnCongeType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCongeType.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCongeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongeType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCongeType.Location = new System.Drawing.Point(316, 268);
            this.btnCongeType.Name = "btnCongeType";
            this.btnCongeType.Size = new System.Drawing.Size(206, 80);
            this.btnCongeType.TabIndex = 19;
            this.btnCongeType.Tag = "GestionStock";
            this.btnCongeType.Text = "Type de congé";
            this.btnCongeType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCongeType.UseVisualStyleBackColor = false;
            this.btnCongeType.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnService
            // 
            this.btnService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnService.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnService.BackgroundImage")));
            this.btnService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnService.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnService.Location = new System.Drawing.Point(316, 159);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(206, 80);
            this.btnService.TabIndex = 18;
            this.btnService.Tag = "GestionStock";
            this.btnService.Text = "Service";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAgent
            // 
            this.btnAgent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgent.BackgroundImage")));
            this.btnAgent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgent.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgent.Location = new System.Drawing.Point(316, 50);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(206, 80);
            this.btnAgent.TabIndex = 7;
            this.btnAgent.Tag = "ProduitsStock";
            this.btnAgent.Text = "Agents";
            this.btnAgent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgent.UseVisualStyleBackColor = false;
            this.btnAgent.Click += new System.EventHandler(this.btnProduitsStock_Click);
            // 
            // btnDemande
            // 
            this.btnDemande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDemande.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDemande.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDemande.BackgroundImage")));
            this.btnDemande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDemande.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDemande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemande.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemande.Location = new System.Drawing.Point(72, 50);
            this.btnDemande.Name = "btnDemande";
            this.btnDemande.Size = new System.Drawing.Size(206, 189);
            this.btnDemande.TabIndex = 8;
            this.btnDemande.Tag = "Stock";
            this.btnDemande.Text = "Demande";
            this.btnDemande.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDemande.UseVisualStyleBackColor = false;
            this.btnDemande.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnRole
            // 
            this.btnRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRole.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRole.BackgroundImage")));
            this.btnRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRole.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRole.Location = new System.Drawing.Point(72, 268);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(206, 80);
            this.btnRole.TabIndex = 20;
            this.btnRole.Tag = "GestionStock";
            this.btnRole.Text = "Role";
            this.btnRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(603, 382);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnCongeType);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.btnDemande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnDemande;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnCongeType;
        private System.Windows.Forms.ToolStripMenuItem typeDeCongéToolStripMenuItem;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
    }
}