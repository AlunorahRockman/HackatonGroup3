namespace WindowsFormsApp3
{
    partial class AjouterUtilisateur
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernom = new System.Windows.Forms.TextBox();
            this.useradresse = new System.Windows.Forms.TextBox();
            this.usertel = new System.Windows.Forms.TextBox();
            this.usermot = new System.Windows.Forms.TextBox();
            this.annuler = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nom et Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tél";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mot de passe :";
            // 
            // usernom
            // 
            this.usernom.Location = new System.Drawing.Point(124, 54);
            this.usernom.Name = "usernom";
            this.usernom.Size = new System.Drawing.Size(190, 20);
            this.usernom.TabIndex = 15;
            // 
            // useradresse
            // 
            this.useradresse.Location = new System.Drawing.Point(124, 87);
            this.useradresse.Name = "useradresse";
            this.useradresse.Size = new System.Drawing.Size(190, 20);
            this.useradresse.TabIndex = 14;
            // 
            // usertel
            // 
            this.usertel.Location = new System.Drawing.Point(124, 119);
            this.usertel.Name = "usertel";
            this.usertel.Size = new System.Drawing.Size(190, 20);
            this.usertel.TabIndex = 13;
            // 
            // usermot
            // 
            this.usermot.Location = new System.Drawing.Point(124, 23);
            this.usermot.Name = "usermot";
            this.usermot.Size = new System.Drawing.Size(190, 20);
            this.usermot.TabIndex = 12;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(166, 162);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(111, 40);
            this.annuler.TabIndex = 21;
            this.annuler.Text = "ANNULER";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(49, 162);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(111, 40);
            this.enregistrer.TabIndex = 20;
            this.enregistrer.Text = "ENREGISTRER";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // AjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 212);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernom);
            this.Controls.Add(this.useradresse);
            this.Controls.Add(this.usertel);
            this.Controls.Add(this.usermot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvel Utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernom;
        private System.Windows.Forms.TextBox useradresse;
        private System.Windows.Forms.TextBox usertel;
        private System.Windows.Forms.TextBox usermot;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button enregistrer;
    }
}