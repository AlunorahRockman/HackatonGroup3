namespace WindowsFormsApp3
{
    partial class AjouterClient
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
            this.namesclient = new System.Windows.Forms.TextBox();
            this.telclient = new System.Windows.Forms.TextBox();
            this.adressclient = new System.Windows.Forms.TextBox();
            this.sexeclient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesclient
            // 
            this.namesclient.Location = new System.Drawing.Point(104, 13);
            this.namesclient.Name = "namesclient";
            this.namesclient.Size = new System.Drawing.Size(191, 20);
            this.namesclient.TabIndex = 0;
            // 
            // telclient
            // 
            this.telclient.Location = new System.Drawing.Point(104, 65);
            this.telclient.Name = "telclient";
            this.telclient.Size = new System.Drawing.Size(191, 20);
            this.telclient.TabIndex = 3;
            // 
            // adressclient
            // 
            this.adressclient.Location = new System.Drawing.Point(104, 39);
            this.adressclient.Name = "adressclient";
            this.adressclient.Size = new System.Drawing.Size(191, 20);
            this.adressclient.TabIndex = 4;
            // 
            // sexeclient
            // 
            this.sexeclient.FormattingEnabled = true;
            this.sexeclient.Items.AddRange(new object[] {
            "Féminin",
            "Masculin"});
            this.sexeclient.Location = new System.Drawing.Point(104, 92);
            this.sexeclient.Name = "sexeclient";
            this.sexeclient.Size = new System.Drawing.Size(121, 21);
            this.sexeclient.TabIndex = 5;
            this.sexeclient.Text = "Masculin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom et Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tél :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexe :";
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(45, 128);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(102, 38);
            this.enregistrer.TabIndex = 10;
            this.enregistrer.Text = "ENREGISTRER";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(153, 128);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(102, 38);
            this.annuler.TabIndex = 11;
            this.annuler.Text = "ANNULER";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // AjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 177);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sexeclient);
            this.Controls.Add(this.adressclient);
            this.Controls.Add(this.telclient);
            this.Controls.Add(this.namesclient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namesclient;
        private System.Windows.Forms.TextBox telclient;
        private System.Windows.Forms.TextBox adressclient;
        private System.Windows.Forms.ComboBox sexeclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button annuler;
    }
}