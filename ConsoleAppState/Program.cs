using ConsoleAppState.States;
using System;

namespace ConsoleAppState
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHY???

            //minimaize duplication of code
            //decoupling of code/ca
            //swap algorithyms at runtime - without the use of if and/or switch statements
            //it does its own thing

            //Object maintains its own internal state
            //different states are represented by different classes vs strategy - algorthym is also a class
            //State changes at runtime

            CatContext catContext = new CatContext(typeof(SleepingState), 100);
            Console.WriteLine("Im receiving food....");
            catContext.ReceiveFood(110);

            Console.WriteLine("Im finished eating....");
            catContext.FinishEating();

            catContext.CompletePlan();

            Console.ReadLine();
        }
    }
}
