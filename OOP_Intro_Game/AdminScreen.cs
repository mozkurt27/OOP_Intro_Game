using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro_Game
{
    public partial class AdminScreen : Form
    {
        internal Main AnaForms;
        internal Users user;
        public AdminScreen(Main f1)
        {
            AnaForms = f1;
            
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            user = AnaForms.EnteredUser;
            lblWelcome.Text = $"{AnaForms.EnteredUser.Name} Hoşgeldin!!!";
        }
        private void AdminScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            AnaForms.Show();
        }

        private void btnHepsiGör_Click(object sender, EventArgs e)
        {
            AdminRandevu adminRandevu = new AdminRandevu(this);
            Hide();
            adminRandevu.Show();
        }

        private void btnExiting_Click(object sender, EventArgs e)
        {
            Dispose();
            AnaForms.Show();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor addDoc = new AddDoctor(this);
            Hide();
            addDoc.Show();
        }
    }
}
