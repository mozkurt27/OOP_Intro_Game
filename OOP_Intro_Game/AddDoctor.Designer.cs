namespace OOP_Intro_Game
{
    partial class AddDoctor
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
            this.txtDName = new System.Windows.Forms.TextBox();
            this.txtDBranch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(105, 24);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(164, 20);
            this.txtDName.TabIndex = 0;
            // 
            // txtDBranch
            // 
            this.txtDBranch.Location = new System.Drawing.Point(105, 59);
            this.txtDBranch.Name = "txtDBranch";
            this.txtDBranch.Size = new System.Drawing.Size(164, 20);
            this.txtDBranch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doktorun Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktorun Branşı:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReback
            // 
            this.btnReback.Location = new System.Drawing.Point(194, 107);
            this.btnReback.Name = "btnReback";
            this.btnReback.Size = new System.Drawing.Size(75, 23);
            this.btnReback.TabIndex = 5;
            this.btnReback.Text = "Geri Dön";
            this.btnReback.UseVisualStyleBackColor = true;
            this.btnReback.Click += new System.EventHandler(this.btnReback_Click);
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.btnReback);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDBranch);
            this.Controls.Add(this.txtDName);
            this.Name = "AddDoctor";
            this.Text = "AddDoctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDoctor_FormClosing);
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtDBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReback;
    }
}