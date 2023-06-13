using ExampleClassLibrary.Chapter2.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.Entity
{
    public class TaxableEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public char Sex { get; set; }
        public string Location { get; set; }
        public TaxParamVO taxparams { get; set; }
    }
}
