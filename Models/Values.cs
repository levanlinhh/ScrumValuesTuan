using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScumvaluesMini.Models
{
    public class Values
    {
        public int id { get; set; }
        public string name { get; set; }
        //public bool IsCheck { get; set; }
        public int score { get; set; }
        //public int score1 { get; set; }

        //public int score2 { get; set; }

        //public int score3 { get; set; }

        //public int score4 { get; set; }

        public class ValuesList1
        {
            public List<Values> values { get; set; }
        }
        //public int score { get; set; }

    }
}
