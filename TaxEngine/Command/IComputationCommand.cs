using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.Command
{
    internal interface IComputationCommand
    {
        bool PreExecute(ComputationContext ctx);
        bool Execute(ComputationContext ctx);
        bool PostExecute(ComputationContext ctx);
    }
}
