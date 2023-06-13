using ExampleClassLibrary.Chapter2.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.DTO
{
    internal class TaxDTO
    {
        public int id { get; set; }
        public TaxParamVO taxparams { get; set; }
    }
}
