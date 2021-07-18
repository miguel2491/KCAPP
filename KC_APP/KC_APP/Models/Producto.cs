using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KC_APP.Models
{
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
    }
}
