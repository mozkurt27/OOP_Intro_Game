namespace OOP_Intro_Game
{
    partial class AdminScreen
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
            this.btnHepsiGör = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnExiting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(1, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(322, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "???";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHepsiGör
            // 
            this.btnHepsiGör.Location = new System.Drawing.Point(1, 105);
            this.btnHepsiGör.Name = "btnHepsiGör";
            this.btnHepsiGör.Size = new System.Drawing.Size(156, 44);
            this.btnHepsiGör.TabIndex = 1;
            this.btnHepsiGör.Text = "Tüm Randevuları Gör";
            this.btnHepsiGör.UseVisualStyleBackColor = true;
            this.btnHepsiGör.Click += new System.EventHandler(this.btnHepsiGör_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(163, 105);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(160, 44);
            this.btnAddDoctor.TabIndex = 2;
            this.btnAddDoctor.Text = "Doktor Ekle";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnExiting
            // 
            this.btnExiting.Location = new System.Drawing.Point(103, 155);
            this.btnExiting.Name = "btnExiting";
            this.btnExiting.Size = new System.Drawing.Size(110, 30);
            this.btnExiting.TabIndex = 3;
            this.btnExiting.Text = "Çıkış Yap";
            this.btnExiting.UseVisualStyleBackColor = true;
            this.btnExiting.Click += new System.EventHandler(this.btnExiting_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 197);
            this.Controls.Add(this.btnExiting);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.btnHepsiGör);
            this.Controls.Add(this.lblWelcome);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminScreen_FormClosing);
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnHepsiGör;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnExiting;
    }
}