using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KC_APP.Models
{
    public class Establecimiento
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string f_captura { get; set; }
        public int status_envio { get; set; }
    }
}
