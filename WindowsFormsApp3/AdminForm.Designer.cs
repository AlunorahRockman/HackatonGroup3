namespace WindowsFormsApp3
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvProduit = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvclient = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvutilis = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprecompte = new System.Windows.Forms.ToolStripMenuItem();
            this.supreproduit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvProduit,
            this.nouvclient,
            this.nouvutilis});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouvProduit
            // 
            this.nouvProduit.Name = "nouvProduit";
            this.nouvProduit.Size = new System.Drawing.Size(168, 22);
            this.nouvProduit.Text = "Nouveau Produit";
            this.nouvProduit.Click += new System.EventHandler(this.nouvProduit_Click);
            // 
            // nouvclient
            // 
            this.nouvclient.Name = "nouvclient";
            this.nouvclient.Size = new System.Drawing.Size(168, 22);
            this.nouvclient.Text = "Nouveau Client";
            this.nouvclient.Click += new System.EventHandler(this.nouvclient_Click);
            // 
            // nouvutilis
            // 
            this.nouvutilis.Name = "nouvutilis";
            this.nouvutilis.Size = new System.Drawing.Size(168, 22);
            this.nouvutilis.Text = "Nouvel Utilisateur";
            this.nouvutilis.Click += new System.EventHandler(this.nouvutilis_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suprecompte,
            this.supreproduit});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // suprecompte
            // 
            this.suprecompte.Name = "suprecompte";
            this.suprecompte.Size = new System.Drawing.Size(183, 22);
            this.suprecompte.Text = "Suprimer un compte";
            // 
            // supreproduit
            // 
            this.supreproduit.Name = "supreproduit";
            this.supreproduit.Size = new System.Drawing.Size(183, 22);
            this.supreproduit.Text = "Suprimer un produit";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 749);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrateur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvProduit;
        private System.Windows.Forms.ToolStripMenuItem nouvclient;
        private System.Windows.Forms.ToolStripMenuItem nouvutilis;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprecompte;
        private System.Windows.Forms.ToolStripMenuItem supreproduit;
    }
}

