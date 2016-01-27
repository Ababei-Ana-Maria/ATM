using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUIZ_ATM
{
    public class u_statistica
    {
        private int _idutilizator;
        private int _medie;
        private int _punctaj;
        private int _testeparcurse;

        public u_statistica()
        {
            //constructor
        }
        public int idutilizator
        {
            get
            {
                return _idutilizator;
            }
            set
            {
                _idutilizator = value;
            }
        }
        public int medie
        {
            get
            {
                return _medie;
            }
            set
            {
                _medie = value;
            }
        }
        public int punctaj
        {
            get
            {
                return _punctaj;
            }
            set
            {
                _punctaj= value;
            }
        }
        public int testeparcurse
        {
            get
            {
                return _testeparcurse;
            }
            set
            {
                _testeparcurse = value;
            }
        }
    }
}