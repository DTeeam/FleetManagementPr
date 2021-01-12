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
        private List<Veichles> displayVeichles;

        public CompanyDB()
        {
            conn = new NpgsqlConnection("Server=kandula.db.elephantsql.com; User id=hquqeprc;" +
                "Password=uIdcHgUGzYOpalq5O1df9z4uIHSipTW9; Database=hquqeprc;");
            conn.Open();

            displayPlaces = new List<Places>();
            displayVeichles = new List<Veichles>();
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
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string postNum = reader.GetString(2);

                        Places reading = new Places(id, name, postNum);

                        displayPlaces.Add(reading);
                    }
                }
                return displayPlaces;
            }
        }

        public void addPlace(Places add)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  addPlace('" + add.name + "', '" + add.postalNum + "');", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void updatePlace(Places update)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  updatePlace(" + update.id + ", '" + update.name + "', '" + update.postalNum + "');", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public List<Veichles> readVeichles()
        {
            List<Veichles> displayVeichles = new List<Veichles>();
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                using (NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM printVeichles()", conn))
                {
                    // com.CommandText = "SELECT printPlaces()";
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        int id = reader.GetInt32(0);
                        string type = reader.GetString(1);
                        int year = reader.GetInt32(2);
                        string model = reader.GetString(3);
                        string make = reader.GetString(4);
                        string place = reader.GetString(5);

                        Veichles reading = new Veichles(id, type, year, make, model, place);

                        displayVeichles.Add(reading);
                    }
                }
                return displayVeichles;
            }
        }

        public List<Veichles> readMakes()
        {
            List<Veichles> displayMakes = new List<Veichles>();
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                using (NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM printModels()", conn))
                {
                    // com.CommandText = "SELECT printPlaces()";
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        string make = reader.GetString(0);

                        Veichles reading = new Veichles(make);

                        displayMakes.Add(reading);
                    }
                }
                return displayMakes;
            }
        }
    }
}
