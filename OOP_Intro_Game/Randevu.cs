using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro_Game
{
    class Randevu
    {

        private string _Name;
        private string _Summary;
        private List<Doctor> _Doctor;
        private DateTime _Time=new DateTime();

        public string Name { get { return _Name; } set { _Name = value; } }
        public string Summary { get { return _Summary; } set { _Summary = value; } }
        public List<Doctor> Doctor { get { return _Doctor; } set { _Doctor = value; } }

        public DateTime Time { get { return _Time; } set { _Time = value; } }

        
    }
}
