using ExampleClassLibrary.Chapter2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.Command
{
    internal class SeniorCitizenCommand : ComputationCommandBase
    {
        public bool Execute(ComputationContext ctx)
        {
            TaxDTO td = (TaxDTO)ctx.Get("tax_cargo");
            td.taxparams.TaxLiability = 1000;
            td.taxparams.Computed = true;
            return true;
        }
    }
}
