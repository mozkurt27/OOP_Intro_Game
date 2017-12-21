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
    public partial class UsersScreen : Form
    {
        internal Main AnaFormu;
        internal Users user;

        
        public UsersScreen(Main f1)
        {
            AnaFormu = f1;
            
            InitializeComponent();
        }

        private void UsersScreen_Load(object sender, EventArgs e)
        {
            user = AnaFormu.EnteredUser;
            lblWelcome.Text = $"{AnaFormu.EnteredUser.Name} Hoşgeldin!!!";
        }

        private void UsersScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            AnaFormu.Show();
        }

        private void btnExiting_Click(object sender, EventArgs e)
        {
            Dispose();
            AnaFormu.Show();
        }

        private void btnGor_Click(object sender, EventArgs e)
        {
            

            UserRandevu userRandevu = new UserRandevu(this);
            Hide();
            userRandevu.Show();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            UserGetRandevu userGetRandevu = new UserGetRandevu(this);
            Hide();
            userGetRandevu.Show();
        }
    }
}
