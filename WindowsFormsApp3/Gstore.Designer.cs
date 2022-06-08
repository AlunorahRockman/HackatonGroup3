namespace WindowsFormsApp3
{
    partial class Gstore
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
            this.Employ = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employ
            // 
            this.Employ.Location = new System.Drawing.Point(75, 13);
            this.Employ.Name = "Employ";
            this.Employ.Size = new System.Drawing.Size(224, 60);
            this.Employ.TabIndex = 0;
            this.Employ.Text = "EMPLOYES";
            this.Employ.UseVisualStyleBackColor = true;
            this.Employ.Click += new System.EventHandler(this.Employ_Click);
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(73, 83);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(224, 60);
            this.admin.TabIndex = 1;
            this.admin.Text = "ADMINISTRATEUR";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Gstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 161);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.Employ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gstore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Employ;
        private System.Windows.Forms.Button admin;
    }
}