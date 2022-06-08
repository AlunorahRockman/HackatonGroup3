namespace WindowsFormsApp3
{
    partial class AjouterProduit
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
            this.engregistrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.inputID = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputType = new System.Windows.Forms.TextBox();
            this.inputCategory = new System.Windows.Forms.TextBox();
            this.inputBarreCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputprix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // engregistrer
            // 
            this.engregistrer.Location = new System.Drawing.Point(54, 229);
            this.engregistrer.Name = "engregistrer";
            this.engregistrer.Size = new System.Drawing.Size(111, 40);
            this.engregistrer.TabIndex = 0;
            this.engregistrer.Text = "ENREGISTRER";
            this.engregistrer.UseVisualStyleBackColor = true;
            this.engregistrer.Click += new System.EventHandler(this.engregistrer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(171, 229);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(111, 40);
            this.annuler.TabIndex = 1;
            this.annuler.Text = "ANNULER";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(129, 22);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(190, 20);
            this.inputID.TabIndex = 2;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(129, 150);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(190, 20);
            this.inputName.TabIndex = 3;
            // 
            // inputType
            // 
            this.inputType.Location = new System.Drawing.Point(129, 118);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(190, 20);
            this.inputType.TabIndex = 4;
            // 
            // inputCategory
            // 
            this.inputCategory.Location = new System.Drawing.Point(129, 86);
            this.inputCategory.Name = "inputCategory";
            this.inputCategory.Size = new System.Drawing.Size(190, 20);
            this.inputCategory.TabIndex = 5;
            // 
            // inputBarreCode
            // 
            this.inputBarreCode.Location = new System.Drawing.Point(129, 53);
            this.inputBarreCode.Name = "inputBarreCode";
            this.inputBarreCode.Size = new System.Drawing.Size(190, 20);
            this.inputBarreCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Barre Code :";
            // 
            // inputprix
            // 
            this.inputprix.Location = new System.Drawing.Point(129, 181);
            this.inputprix.Name = "inputprix";
            this.inputprix.Size = new System.Drawing.Size(125, 20);
            this.inputprix.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prix :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ar";
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 277);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputprix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBarreCode);
            this.Controls.Add(this.inputCategory);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.engregistrer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau Produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button engregistrer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputType;
        private System.Windows.Forms.TextBox inputCategory;
        private System.Windows.Forms.TextBox inputBarreCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputprix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}