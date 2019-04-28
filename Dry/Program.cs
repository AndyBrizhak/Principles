using System;
using System.Collections.Generic;


namespace Dry
{
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        private static void MakeAction(Action action)
        {
            var nameMethod = action.Method.Name;
            Console.WriteLine($"Start  {nameMethod}");
            action();
            Console.WriteLine($"Finish {nameMethod}");
        }

        static void Main(string[] args)
        {


            //Console.WriteLine("Start DummyFunc");
            //DummyFunc();
            //Console.WriteLine("Finish DummyFunc");

            //Console.WriteLine("Start DummyFuncAgain");
            //DummyFuncAgain();
            //Console.WriteLine("Finish DummyFuncAgain");

            //Console.WriteLine("Start DummyFuncMore");
            //DummyFuncMore();
            //Console.WriteLine("Finish DummyFuncMore");

            //MakeAction(DummyFunc);
            //MakeAction(DummyFuncAgain);
            //MakeAction(DummyFuncMore);

            List<Action> actions = GetActionSteps();
            foreach (var action in actions)
            {
                MakeAction(action);
            }

            Console.ReadLine();
        }

        private static void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(Format, name, description, Address, age);
        }

        private static void DummyFunc()
        {
            
            //string address = Constants.Address;
            //string format = Constants.Format;
            //Console.WriteLine(Format, "Петя", "школьный друг", Address, 30);
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            //string address = Constants.Address;
            //string format = Constants.Format;
            //Console.WriteLine(Format, "Вася", "сосед", Address, 54);
            WriteToConsole("Вася", "сосед", 54);
        }
        private static void DummyFuncMore()
        {
            //string address = Constants.Address;
            //string format = Constants.Format;
            //Console.WriteLine(Format, "Николай", "сын", Address, 4);
            WriteToConsole("Николай", "сын", 4);
        }

        private static List<Action> GetActionSteps()
        {
            return new List<Action>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }
    }
}
