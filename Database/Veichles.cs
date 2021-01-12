using System;
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

        public Veichles(int id, string type, int year, string make, string model)
        {
            this.id = id;
            this.type = type;
            this.yearOfMake = year;
            this.make = make;
            this.model = model;
        }
    }
}
