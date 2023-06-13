namespace ExampleClassLibrary.Chapter2.Command
{
    internal abstract class ComputationCommandBase : IComputationCommand
    {
        public virtual bool PreExecute(ComputationContext ctx)
        {
            return true;
        }
        public virtual bool Execute(ComputationContext ctx) 
        {
            return true;
        }
        public virtual bool PostExecute(ComputationContext ctx)
        {
            return true;
        }

    }
}