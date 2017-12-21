using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro_Game
{
    class Doctor
    {
        private string _DName;
        private string _DBranch;

        public string DName { get { return _DName; } set { _DName = value; } }
        public string DBranch { get { return _DBranch; } set { _DBranch = value; } }

        public override string ToString()
        {
            return $"{_DName},{_DBranch}";
        }
    }
}
