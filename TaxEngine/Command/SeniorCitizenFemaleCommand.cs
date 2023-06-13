using ExampleClassLibrary.Chapter2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.Command
{
    internal class SeniorCitizenFemaleCommand : ComputationCommandBase
    {
        public bool Execute(ComputationContext ctx)
        {
            TaxDTO td = (TaxDTO)ctx.Get("tax_cargo");
            double accum = td.taxparams.Basic +
                td.taxparams.DA + td.taxparams.Allowance +
                td.taxparams.HRA;
            double net = accum - td.taxparams.Deductions -
                td.taxparams.Surcharge;
            //---- Flat 10% Tax
            td.taxparams.TaxLiability = net * 0.1;
            td.taxparams.Computed = true;
            return true;
        }
    }
}
