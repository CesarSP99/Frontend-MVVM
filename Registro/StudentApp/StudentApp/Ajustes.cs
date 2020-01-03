using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
    class Ajustes
    {
        static public string APIURL { get; set; }
        public Ajustes()
        {
            APIURL = @"https://localhost:44393/";
        }
    }
}
