using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro_Game
{
    class Users
    {
        private string _UserName;
        private string _UserPass;
        private string _Name;
        private int _Tc;
        private bool _Aut_Level;
        private List<Randevu> _Randevu;


        
        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public List<Randevu> Randevu { get { return _Randevu; } set { _Randevu = value; } }

        public string UserPass
        {
            get
            {
                return _UserPass;
            }
            set
            {
                _UserPass = value;
            }
        }
        
        public string Name { get { return _Name; } set { _Name = value; } }
        public int Tc { get { return _Tc; } set { _Tc = value; } }

        public bool Aut_Level { get { return _Aut_Level; } set { _Aut_Level = value; } }

    }
}