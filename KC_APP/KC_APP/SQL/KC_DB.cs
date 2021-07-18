using KC_APP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace KC_APP.SQL
{
    public class KC_DB
    {
        private SQLiteConnection conn;

        public KC_DB()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Establecimiento>();
            conn.CreateTable<Producto>();
            conn.CreateTable<Lista>();
        }
        //Listas

        //Productos
        public string AddProducto(Producto member)
        {
            try
            {
                conn.Insert(member);
                return "success Producto Agregado";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public IEnumerable<Producto> GetProducto()
        {
            var members = (from mem in conn.Table<Producto>() select mem);
            return members.ToList();
        }

        public void DeleteAllProducto()
        {
            conn.DeleteAll<Producto>();
        }
        //Establecimiento
        public string AddEstablecimiento(Establecimiento member)
        {
            try
            {
                conn.Insert(member);
                return "success Establecimiento Agregado";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public IEnumerable<Establecimiento> GetEstablecimiento()
        {
            var members = (from mem in conn.Table<Establecimiento>() select mem);
            return members.ToList();
        }

        public string DeleteEstablecimiento(int ID)
        {
            try
            {
                conn.Delete<Establecimiento>(ID);
                return "success Establecimiento deleted ";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public void DeleteAllEstablecimiento()
        {
            conn.DeleteAll<Establecimiento>();
        }
    }
}
