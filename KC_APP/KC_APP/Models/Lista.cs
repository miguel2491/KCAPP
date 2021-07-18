using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KC_APP.Models
{
    public class Lista
    {
        [PrimaryKey]
        public int id { get; set; }
        public int id_tabla { get; set; }
        public int id_lista { get; set; }
        public int id_producto { get; set; }
        public float precio { get; set; }
        public int id_establecimiento { get; set; }
        public string fecha { get; set; }
        public int check { get; set; }
    }
}
