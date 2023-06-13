using ExampleClassLibrary.Chapter2.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2.Dispatcher
{
    internal class CommandDispatcher
    {
        public static IDictionary<string, IComputationCommand> ComputationCommandFactory => GetComputationCommandFactory();
        public static bool Dispatch(string archetype, ComputationContext ctx)
        {
            if(ComputationCommandFactory.TryGetValue(archetype, out var computationCommand) == false)
            {
                return false;
            }

           if(computationCommand.PreExecute(ctx))
           {
                bool rs = computationCommand.Execute(ctx);

                computationCommand.PostExecute(ctx);

                return rs;
           }
            return false;
        }

        // computationCommandFactory
        public static IDictionary<string, IComputationCommand> GetComputationCommandFactory()
        {
            return new Dictionary<string, IComputationCommand>()
            {
                { "SeniorCitizen", new SeniorCitizenCommand() },
                { "OrdinaryCitizen", new  OrdinaryCitizenCommand() }
            };
        }
    }
}
