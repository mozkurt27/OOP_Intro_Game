namespace OOP_Intro_Game
{
    partial class UsersScreen
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.btnGor = new System.Windows.Forms.Button();
            this.btnExiting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(387, 53);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "???";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(28, 84);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(158, 45);
            this.btnAl.TabIndex = 1;
            this.btnAl.Text = "Randevu AL";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btnGor
            // 
            this.btnGor.Location = new System.Drawing.Point(192, 84);
            this.btnGor.Name = "btnGor";
            this.btnGor.Size = new System.Drawing.Size(179, 45);
            this.btnGor.TabIndex = 2;
            this.btnGor.Text = "Randevuları Gör";
            this.btnGor.UseVisualStyleBackColor = true;
            this.btnGor.Click += new System.EventHandler(this.btnGor_Click);
            // 
            // btnExiting
            // 
            this.btnExiting.Location = new System.Drawing.Point(139, 152);
            this.btnExiting.Name = "btnExiting";
            this.btnExiting.Size = new System.Drawing.Size(98, 40);
            this.btnExiting.TabIndex = 3;
            this.btnExiting.Text = "Çıkış Yap";
            this.btnExiting.UseVisualStyleBackColor = true;
            this.btnExiting.Click += new System.EventHandler(this.btnExiting_Click);
            // 
            // UsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 204);
            this.Controls.Add(this.btnExiting);
            this.Controls.Add(this.btnGor);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.lblWelcome);
            this.Name = "UsersScreen";
            this.Text = "UsersScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersScreen_FormClosing);
            this.Load += new System.EventHandler(this.UsersScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnGor;
        private System.Windows.Forms.Button btnExiting;
    }
}