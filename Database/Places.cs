using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Places
    {
        public string name { get; set; }
        public string postalNum { get; set; }
        public Places(string name, string postNum)
        {
            this.name = name;
            this.postalNum = postNum;
        }

        public Places(string name)
        {
            this.name = name;
        }
    }

}
