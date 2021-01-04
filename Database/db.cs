using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class db
    {
        public int? ID { get; set; }
        public string name { get; set; }
    }

    class places : db
    {  
        public int postalNum { get; set; }
    }
}
