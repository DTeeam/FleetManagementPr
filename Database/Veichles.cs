﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Veichles
    {

        public int id { get; set; }
        public string type { get; set; }
        public int yearOfMake { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string place { get; set; }
        public int modelID { get; set; }
        public int placeID { get; set; }

        public Veichles(int id, string type, int year, string make, string model, string place)
        {
            this.id = id;
            this.type = type;
            this.yearOfMake = year;
            this.make = make;
            this.model = model;
            this.place = place;
        }

        public Veichles(string model)
        {
            this.model = model;
        }
       

        public Veichles(string type, int year, int modelID, int placeID)
        {
            this.type = type;
            this.yearOfMake = year;
            this.modelID = modelID;
            this.placeID = placeID;
        }

        public Veichles(int id)
        {
            this.id = id;
        }

        public Veichles(int id, string type, int yearOfMake, int modelID, int placeID)
        {
            this.id = id;
            this.type = type;
            this.yearOfMake = yearOfMake;
            this.modelID = modelID;
            this.placeID = placeID;
        }
    }
}
