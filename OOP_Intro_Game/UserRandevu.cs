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
    public partial class UserRandevu : Form
    {
        UsersScreen usersScreen;
        internal Users user;

        public UserRandevu(UsersScreen u1)
        {
            usersScreen = u1;
            user = u1.user;
            InitializeComponent();
        }

        

        private void UserRandevu_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Ad", 75);
            listView1.Columns.Add("Özet", 75);
            listView1.Columns.Add("DName", 75);
            listView1.Columns.Add("Dbranş", 75);
            listView1.Columns.Add("time", 75);

            foreach (Randevu r in user.Randevu)
            {
                

                string[] s = { r.Name, r.Summary, (r.Doctor[0].ToString()).Split(',')[0], (r.Doctor[0].ToString()).Split(',')[1], r.Time.ToShortDateString() };

                listView1.Items.Add(new ListViewItem(s));
            }
        }

        private void UserRandevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            usersScreen.Show();
        }

        private void btnReback_Click(object sender, EventArgs e)
        {
            Dispose();
            usersScreen.Show();
        }
    }
}
