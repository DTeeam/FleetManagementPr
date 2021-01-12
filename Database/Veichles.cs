using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Veichles
    {
        public string type { get; set; }
        public int yearOfMake { get; set; }
        public string make { get; set; }
        public string model { get; set; }

        public Veichles(string type, int year, string make, string model)
        {
            this.type = type;
            this.yearOfMake = year;
            this.make = make;
            this.model = model;
        }
    }
}
