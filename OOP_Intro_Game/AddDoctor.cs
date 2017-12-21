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
    public partial class AddDoctor : Form
    {

        AdminScreen adminScreen;
        public AddDoctor(AdminScreen aScreen)
        {
            adminScreen = aScreen;
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            adminScreen.Show();
        }

        private void btnReback_Click(object sender, EventArgs e)
        {
            Dispose();
            adminScreen.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtDName.Text;
            string branch = txtDBranch.Text;

            Doctor d = new Doctor() { DName = name, DBranch = branch };

            adminScreen.AnaForms.Doctors.Add(d);

            MessageBox.Show("Eklendi");

        }
    }
}
