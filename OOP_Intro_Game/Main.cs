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
    public partial class Main : Form
    {
        internal List<Users> User = new List<Users>();
        internal Users EnteredUser;
        internal List<Doctor> Doctors = new List<Doctor>();
        internal List<Randevu> Randevus = new List<Randevu>();

        Doctor d1 = new Doctor() { DName = "veli", DBranch = "KBB" };
        Doctor d2 = new Doctor() { DName = "mutlu", DBranch = "Göğüs" };
        Randevu r1 = new Randevu() { Name = "ali", Summary = "sdfsdsd", Doctor = new List<Doctor>(), Time = new DateTime(2016, 05, 20) };
        Randevu r2 = new Randevu() { Name = "ali", Summary = "sdfsdsd", Doctor = new List<Doctor>(), Time = new DateTime(2016, 05, 20) };
        Randevu r3 = new Randevu() { Name = "veli", Summary = "sdfsdsd", Doctor = new List<Doctor>(), Time = new DateTime(2016, 05, 20) };
        

        Users u1 = new Users() { Name = "ali", Tc = 123, UserName = "admin1", UserPass = "123", Aut_Level = true, Randevu = new List<Randevu>() };
        Users u2 = new Users() { Name = "veli", Tc = 321, UserName = "admin2", UserPass = "123", Aut_Level = true , Randevu = new List<Randevu>() };
        Users u3 = new Users() { Name = "muhammed", Tc = 213, UserName = "admin", UserPass = "123", Aut_Level = false , Randevu = new List<Randevu>() };

        public Main()
        {
            InitializeComponent();
           
            r1.Doctor.Add(d1);
            r2.Doctor.Add(d2);
            r3.Doctor.Add(d2);
            u1.Randevu.Add(r1);
            u1.Randevu.Add(r2);
            u2.Randevu.Add(r3);
            u3.Randevu.Add(r1);
            u3.Randevu.Add(r2);
            u3.Randevu.Add(r3);
            User.Add(u1);
            User.Add(u2);
            User.Add(u3);
            Doctors.Add(d1);
            Doctors.Add(d2);
            Randevus.Add(r1);
            Randevus.Add(r2);
            Randevus.Add(r3);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntering_Click(object sender, EventArgs e)
        {
            string Name = txtUserName.Text,Pass = txtUserPass.Text;
            bool Result = true;
            bool Aut_Level = true;
            foreach (Users u in User)
            {
                if (u.UserName == Name)
                {
                    if (u.UserPass == Pass)
                    {
                        Result = true;
                        Aut_Level = u.Aut_Level;
                        EnteredUser = u;
                        break;
                    }
                    else Result = false;


                }
                else Result = false;

            }

            if (Result)
            {
                if (Aut_Level)
                {
                    UsersScreen UserEntering = new UsersScreen(this);
                    Hide();
                    UserEntering.Show();
                    

                }
                else
                {
                    AdminScreen AdminEntering = new AdminScreen(this);
                    Hide();
                    AdminEntering.Show();
                    //MessageBox.Show("admin giris");
                }
            }
            else
            {
                MessageBox.Show("yanlış");
            }
        }
        
        private void btnSaveAs_Click(object sender, EventArgs e)
        {

            Saved saved = new Saved(this);
            Hide();
            saved.Show();

        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
