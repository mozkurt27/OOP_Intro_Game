namespace OOP_Intro_Game
{
    partial class AdminRandevu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnReback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 217);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // btnReback
            // 
            this.btnReback.Location = new System.Drawing.Point(383, 3);
            this.btnReback.Name = "btnReback";
            this.btnReback.Size = new System.Drawing.Size(116, 23);
            this.btnReback.TabIndex = 1;
            this.btnReback.Text = "Geri Dön";
            this.btnReback.UseVisualStyleBackColor = true;
            this.btnReback.Click += new System.EventHandler(this.btnReback_Click);
            // 
            // AdminRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 261);
            this.Controls.Add(this.btnReback);
            this.Controls.Add(this.listView1);
            this.Name = "AdminRandevu";
            this.Text = "AdminRandevu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminRandevu_FormClosing);
            this.Load += new System.EventHandler(this.AdminRandevu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnReback;
    }
}