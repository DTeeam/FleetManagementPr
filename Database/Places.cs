﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Places
    {
        public int id { get; set; }
        public string name { get; set; }
        public string postalNum { get; set; }
        public int numOfVeichles { get; set; }

        public Places(string name, string postNum)
        {
            this.name = name;
            this.postalNum = postNum;
        }

        public Places(string name)
        {
            this.name = name;
        }
        public Places(string name, int veichleNum)
        {
            this.name = name;
            this.numOfVeichles = veichleNum;
        }

        public Places(int id, string name, string postalNum)
        {
            this.id = id;
            this.name = name;
            this.postalNum = postalNum;
        }

        public Places(int id)
        {
            this.id = id;
        }
    }

}
