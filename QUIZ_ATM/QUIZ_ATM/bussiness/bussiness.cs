using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

using QUIZ_ATM.bussiness;
using QUIZ_ATM;

// includeri pentru Entity
using System.Data.Entity;
using System.Data.EntityClient;
using System.Data.Mapping;
using System.Data.Entity.Infrastructure;
using System.Data.EntityModel;

namespace QUIZ_ATM.bussiness
{
    public class bussiness
    {
        public void logare()
        {
            //aceste variabile reprezinta un rand din tabela
            Utilizatori ccc = new Utilizatori();
            Admin adm = new Admin();
            Statistica stat = new Statistica();
            Intrebari intr = new Intrebari();
            Raspunsuri rasp = new Raspunsuri();
            //
        }
        
           
    }
}