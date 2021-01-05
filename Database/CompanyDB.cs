using System;
using System.Configuration;
using Npgsql;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace Database
{
    public class CompanyDB
    {
        private NpgsqlConnection conn;
        private List<Places> displayPlaces;

        public CompanyDB()
        {
            conn = new NpgsqlConnection("Server=kandula.db.elephantsql.com; User id=hquqeprc;" +
                "Password=uIdcHgUGzYOpalq5O1df9z4uIHSipTW9; Database=hquqeprc;");
            conn.Open();

            displayPlaces = new List<Places>();
        }


        public List<Places> readPlaces()
        {
            List<Places> displayPlaces = new List<Places>();
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                using(NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM printPlaces()", conn))
                {
                   // com.CommandText = "SELECT printPlaces()";
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        string name = reader.GetValue(0).ToString();
                        string postNum = reader.GetString(1);

                        Places reading = new Places(name, postNum);

                        displayPlaces.Add(reading);
                    }
                }
                return displayPlaces;
            }
        }
    }
}
