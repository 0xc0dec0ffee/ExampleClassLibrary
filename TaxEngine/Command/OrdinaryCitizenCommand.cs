using ExampleClassLibrary.Chapter2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.Command
{
    internal class OrdinaryCitizenCommand : ComputationCommandBase
    {
        public bool Execute(ComputationContext ctx)
        {
            TaxDTO td = (TaxDTO)ctx.Get("tax_cargo");
            td.taxparams.TaxLiability = 1500;
            td.taxparams.Computed = true;
            return true;
        }
        public override bool PostExecute(ComputationContext ctx)
        {
            // do something

            return base.PostExecute(ctx);
        }
    }
}
