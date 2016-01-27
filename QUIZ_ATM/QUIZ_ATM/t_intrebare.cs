using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUIZ_ATM
{
    public class t_intrebare
    {
        private int _idintrebare;
        private string _text;
        private int _varcorect;
        public t_intrebare()
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
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        public int varcorect
        {
            get
            {
                return _varcorect;
            }
            set
            {
                _varcorect = value;
            }
        }
    }
}