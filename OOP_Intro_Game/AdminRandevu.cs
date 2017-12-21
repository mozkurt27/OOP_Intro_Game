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
    public partial class AdminRandevu : Form
    {
        AdminScreen adminScreen;
        Users user;
        public AdminRandevu(AdminScreen Ascreen)
        {
            adminScreen = Ascreen;
            user = Ascreen.user;
            InitializeComponent();
        }

        private void AdminRandevu_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Ad", 75);
            listView1.Columns.Add("Özet", 75);
            listView1.Columns.Add("DName", 75);
            listView1.Columns.Add("Dbranş", 75);
            listView1.Columns.Add("time", 75);
            
            foreach (Randevu r in adminScreen.AnaForms.Randevus)
            {
                

                string[] s = { r.Name, r.Summary, (r.Doctor[0].ToString()).Split(',')[0], (r.Doctor[0].ToString()).Split(',')[1], r.Time.ToShortDateString() };
                //MessageBox.Show((r.Doctor[0].ToString()).Split(',')[0]+ " " + (r.Doctor[0].ToString()).Split(',')[1]);
                listView1.Items.Add(new ListViewItem(s));
            }


        }

        private void btnReback_Click(object sender, EventArgs e)
        {
            Dispose();
            adminScreen.Show();
        }

        private void AdminRandevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            adminScreen.Show();
        }

        

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[1].ToString());
            }
        }
    }
}
