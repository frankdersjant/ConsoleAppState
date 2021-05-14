using ConsoleAppState.States;
using System;

namespace ConsoleAppState
{
    public class CatContext
    {
        public CatState CurrentState;
        private int HappyWith;

        public CatContext(Type InitialState, int HappyFood)
        {
            if (InitialState == typeof(Sleeping))
                this.CurrentState = new Sleeping(this);

            if (InitialState == typeof(Eating))
                this.CurrentState = new Sleeping(this);

            if (InitialState == typeof(Contemplating))
                this.CurrentState = new Contemplating(this);

            HappyWith = HappyFood;
        }

        public void ReceiveFood(int amount)
        {
            CurrentState.GetsFed(amount, HappyWith);
            Console.WriteLine("I am in ", CurrentState.GetType().Name);
        }

        public void FinishEating()
        {
            CurrentState.BowlEmpty();
            Console.WriteLine("I am in ", CurrentState.GetType().Name);
        }

        public void CompletePlan()
        {
            CurrentState.WorldBeware();
            Console.WriteLine("I am in ", CurrentState.GetType().Name);
        }
        
    }
}
