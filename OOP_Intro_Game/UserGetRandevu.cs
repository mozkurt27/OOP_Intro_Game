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
    
    public partial class UserGetRandevu : Form
    {
        UsersScreen usersScreen;

        public UserGetRandevu(UsersScreen u1)
        {
            usersScreen = u1;
            InitializeComponent();
        }

        private void UserGetRandevu_Load(object sender, EventArgs e)
        {
            foreach (Doctor doc in usersScreen.AnaFormu.Doctors)
            {
                cbDoctor.Items.Add(doc.ToString());
            }
            cbDoctor.SelectedIndex = 0;

        }

        private void UserGetRandevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            usersScreen.Show();
        }

        private void btnReback_Click(object sender, EventArgs e)
        {
            Dispose();
            usersScreen.Show();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            string summary="";
            string name = usersScreen.user.Name;
            Doctor d = usersScreen.AnaFormu.Doctors[cbDoctor.SelectedIndex];
            summary = txtSummary.Text;
            DateTime dtp = dtPicker.Value;
            Randevu r = new Randevu() { Name = name, Summary = summary, Doctor = new List<Doctor>(), Time = dtp };
            r.Doctor.Add(d);

            usersScreen.AnaFormu.Randevus.Add(r);

            usersScreen.user.Randevu.Add(r);

            MessageBox.Show("Randevu alındı");
            
            

        }
    }
}
