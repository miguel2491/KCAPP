using System;
using System.Collections.Generic;
using System.Text;

namespace KC_APP.SQL
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
