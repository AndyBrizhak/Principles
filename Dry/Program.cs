using System;


namespace Dry
{
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;
        static void Main(string[] args)
        {
            DummyFunc();
            DummyFuncAgain();
            DummyFuncMore();
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
    }
}
