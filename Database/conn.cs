using System;
using System.Configuration;
using Npgsql;
using System.Collections.Specialized;

namespace Database
{
    public class conn
    {
        private NpgsqlConnection con;

        public conn()
        {
            con = new NpgsqlConnection("Server=kandula.db.elephantsql.com; User id=hquqeprc;" +
                "Password=uIdcHgUGzYOpalq5O1df9z4uIHSipTW9; Database=hquqeprc;");
            con.Open();
        }
        public void addPlace()
        {
            
        }
    }
}
