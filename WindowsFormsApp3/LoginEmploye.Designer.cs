namespace WindowsFormsApp3
{
    partial class LoginEmploye
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.motdepassemamp = new System.Windows.Forms.TextBox();
            this.idmamp = new System.Windows.Forms.TextBox();
            this.entrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mots de Passe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id:";
            // 
            // motdepassemamp
            // 
            this.motdepassemamp.Location = new System.Drawing.Point(128, 70);
            this.motdepassemamp.Name = "motdepassemamp";
            this.motdepassemamp.Size = new System.Drawing.Size(109, 20);
            this.motdepassemamp.TabIndex = 9;
            // 
            // idmamp
            // 
            this.idmamp.Location = new System.Drawing.Point(128, 29);
            this.idmamp.Name = "idmamp";
            this.idmamp.Size = new System.Drawing.Size(109, 20);
            this.idmamp.TabIndex = 8;
            this.idmamp.Text = " ";
            // 
            // entrer
            // 
            this.entrer.Location = new System.Drawing.Point(53, 121);
            this.entrer.Name = "entrer";
            this.entrer.Size = new System.Drawing.Size(79, 35);
            this.entrer.TabIndex = 7;
            this.entrer.Text = "ENTRER";
            this.entrer.UseVisualStyleBackColor = true;
            this.entrer.Click += new System.EventHandler(this.entrer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(153, 121);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 35);
            this.annuler.TabIndex = 6;
            this.annuler.Text = "ANNULER";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // LoginEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 179);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motdepassemamp);
            this.Controls.Add(this.idmamp);
            this.Controls.Add(this.entrer);
            this.Controls.Add(this.annuler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Employés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox motdepassemamp;
        private System.Windows.Forms.TextBox idmamp;
        private System.Windows.Forms.Button entrer;
        private System.Windows.Forms.Button annuler;
    }
}