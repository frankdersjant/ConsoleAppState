using System;

namespace ConsoleAppState.States
{
    public class Sleeping : CatState
    {
        public Sleeping(CatContext Handle) : base(Handle)
        {}

        public override void GetsFed(int amount, int HappyWith)
        {
            Console.WriteLine("Hmm lekker!");
            this.Handle.CurrentState = new Eating(this.Handle, amount, HappyWith);
        }
    }
}
