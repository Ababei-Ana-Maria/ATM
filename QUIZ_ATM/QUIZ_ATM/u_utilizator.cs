using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace QUIZ_ATM.a
{
    public class u_utilizator
    {
        private int _idutilizator;
        private string _nume;
        private string _prenume;
        private string _mail;
        private string _parola;
        private int _pozitie;

        public u_utilizator()
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
                _idutilizator= value;
            }
        }
        public string nume
        {
            get
            {
                return _nume;
            }
            set
            {
                _nume = value;
            }
        }
        public string prenume
        {
            get
            {
                return _prenume;
            }
            set
            {
                _prenume = value;
            }
        }
        public string mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
            }
        }
        public string parola
        {
            get
            {
                return _parola;
            }
            set
            {
                _parola = value;
            }
        }
        public int pozitie
        {
            get
            {
                return _pozitie;
            }
            set
            {
                _pozitie = value;
            }
        }
    }
}