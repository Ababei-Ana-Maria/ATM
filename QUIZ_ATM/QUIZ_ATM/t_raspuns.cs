using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUIZ_ATM
{
    public class t_raspuns
    {
        private int _idintrebare;
        private string _raspa;
        private string _raspb;
        private string _raspc;
        private string _raspd;
        public t_raspuns()
        {
            //constructor
        }
        public int idintrebare
        {
            get
            {
                return _idintrebare;
            }
            set
            {
                _idintrebare = value;
            }
        }
        public string raspa
        {
            get
            {
                return _raspa;
            }
            set
            {
                _raspa = value;
            }
        }
        public string raspb
        {
            get
            {
                return _raspb;
            }
            set
            {
                _raspb = value;
            }
        }
        public string raspc
        {
            get
            {
                return _raspc;
            }
            set
            {
                _raspc = value;
            }
        }
        public string raspd
        {
            get
            {
                return _raspd;
            }
            set
            {
                _raspd = value;
            }
        }
    }
}