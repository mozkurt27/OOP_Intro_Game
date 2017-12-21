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
    public partial class Saved : Form
    {
        Main AnaForm;
        
        
        public Saved(Main f1)
        {
            AnaForm = f1;
            InitializeComponent();
        }

        private void Saved_Load(object sender, EventArgs e)
        {

        }

        private void Saved_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            AnaForm.Show();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if(txtUserName.Text == "" || txtPass.Text == "" || txtName.Text == "" || txtTC.Text == "")
            {
                MessageBox.Show("Alanlar Boş bırakılamaz");
            }
            else
            {
                foreach (Users u in AnaForm.User)
                {
                    if(u.UserName == txtUserName.Text)
                    {
                        MessageBox.Show("Böyle bir kullanıcı bulunmakta.");
                        break;
                    }
                    else
                    {
                        if(u.Tc == int.Parse(txtTC.Text))
                        {
                            MessageBox.Show("Böyle bir kullanıcı bulunmakta.");
                            break;
                        }
                        else
                        {
                            user.UserName = txtUserName.Text;
                            user.UserPass = txtPass.Text;
                            user.Name = txtName.Text;
                            user.Tc = int.Parse(txtTC.Text);
                            user.Aut_Level = true;
                            user.Randevu = new List<Randevu>();

                            AnaForm.User.Add(user);

                            MessageBox.Show("kayıt işlemi tamam \n Anasayfaya yönlendiriliyorsunuz...");

                            break;



                        }
                    }
                }

                Dispose();
                AnaForm.Show();
            }
        }
    }
}
