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

        public void deletePlace(Places remove)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT deletePlaces(" + remove.id + ")", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void updatePlace(Places update)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  updatePlace(" + update.id + ", '" + update.name +
                    "', '" + update.postalNum + "');", conn);

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
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
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

        public void addVeichle(Veichles add)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  addVeichles('" + add.type + "', " + add.yearOfMake
                    + ", " + add.modelID + ", " + add.placeID + ");", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void updateVeichle(Veichles update)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  updateVeichle(" + update.id + ", '" + update.type +
                    "', " + update.yearOfMake + ", " + update.modelID + ", " + update.placeID + ");", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void deleteVeichle(Veichles remove)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT deleteVeichles(" + remove.id + ")", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public List<Veichles> readMakes()
        {
            List<Veichles> displayMakes = new List<Veichles>();
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                using (NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM printMakes()", conn))
                {
                    // com.CommandText = "SELECT printPlaces()";
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string make = reader.GetString(1);

                        Veichles reading = new Veichles(id, make);

                        displayMakes.Add(reading);
                    }
                }
                return displayMakes;
            }
        }

        public List<Veichles> readModels()
        {
            List<Veichles> displayModels = new List<Veichles>();
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                using (NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM printModels()", conn))
                {
                    // com.CommandText = "SELECT printPlaces()";
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        int id = reader.GetInt32(0);
                        string model = reader.GetString(1);

                        Veichles reading = new Veichles(id, model);

                        displayModels.Add(reading);
                    }
                }
                return displayModels;
            }
        }

        public void addModel(Veichles add)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  addModel('" + add.model + "', " + add.makeID + ");", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }
        public void deleteModel(Veichles remove)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT deleteModel(" + remove.id + ")", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }
        public void updateModel(Veichles update)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  updateModel(" + update.makeID + ", '" + update.model + "');", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }
        public void addMake(Veichles add)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  addMakeModel('" + add.make + "', '" + add.model + "', " + add.makeID + ");", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }
        public void deleteMake(Veichles remove)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT deleteMake(" + remove.id + ")", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void updateMake(Veichles update)
        {
            using (NpgsqlTransaction transaction = conn.BeginTransaction())
            {
                NpgsqlCommand com = new NpgsqlCommand("SELECT  updateMake(" + update.makeID + ", '" + update.make + "');", conn);

                com.ExecuteNonQuery();
                transaction.Commit();
            }
        }
    }
}
