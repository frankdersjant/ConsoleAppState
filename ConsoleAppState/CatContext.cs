using ConsoleAppState.States;
using System;

namespace ConsoleAppState
{
    public class CatContext
    {
        //CatContext is actually the cat!!

        public AbstractCatState CurrentState;
        private int HappyWith;

        public CatContext(Type InitialState, int HappyFood)
        {
            if (InitialState == typeof(SleepingState))
                this.CurrentState = new SleepingState(this);

            if (InitialState == typeof(EatingState))
                this.CurrentState = new SleepingState(this);

            if (InitialState == typeof(ContemplatingState))
                this.CurrentState = new ContemplatingState(this);

            HappyWith = HappyFood;
        }

        public void ReceiveFood(int amount)
        {
            CurrentState.GetsFed(amount, HappyWith);
            Console.WriteLine("I am in {0} ", CurrentState.GetType().Name);
        }

        public void FinishEating()
        {
            CurrentState.BowlEmpty();
            Console.WriteLine("I am in {0} ", CurrentState.GetType().Name);
        }

        public void CompletePlan()
        {
            CurrentState.WorldBeware();
            Console.WriteLine("I am in {0} ", CurrentState.GetType().Name);
        }
    }
}
