using ExampleClassLibrary.Chapter2.Dispatcher;
using ExampleClassLibrary.Chapter2.DTO;
using ExampleClassLibrary.Chapter2.Entity;
using ExampleClassLibrary.Chapter2.VO;

namespace ExampleClassLibrary.Chapter2
{
    public class TaxEngine
    {
        public string GetOK()
        {
            return "OK2";
        }
        public void Demo()
        {
            // prepare data
            TaxableEntity te = new TaxableEntity();
            te.taxparams = new TaxParamVO();
            TaxDTO td = new() { id = te.id, taxparams = te.taxparams };

            ComputationContext ctx = new ComputationContext();
            ctx.Put("tax_cargo", td);

            // get command
            string archetype = ComputeArchetype(te);

            // execute engine
            bool rs = CommandDispatcher.Dispatch(archetype, ctx);
           
        }
        public static string ComputeArchetype(TaxableEntity te)
        {
            return (te.age > 60) ? "SeniorCitizen" : "OrdinaryCitizen";
        }

    }
}