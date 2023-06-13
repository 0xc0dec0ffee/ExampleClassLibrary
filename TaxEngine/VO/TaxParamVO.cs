using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.VO
{
    public class TaxParamVO
    {
        public double Basic { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double Allowance { get; set; }
        public double Deductions { get; set; }
        public double Surcharge { get; set; }
        public double TaxLiability { get; set; }
        public bool Computed { get; set; }
    }
}
