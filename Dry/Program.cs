using System;


namespace Dry
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyFunc();
            DummyFuncAgain();
            DummyFuncMore();
            Console.ReadLine();
        }

        private static void DummyFunc()
        {
            string address = Constants.Address;
            string format = Constants.Format;
            Console.WriteLine(format, "Петя", "школьный друг", address, 30);
        }

        private static void DummyFuncAgain()
        {
            string address = Constants.Address;
            string format = Constants.Format;
            Console.WriteLine(format, "Вася", "сосед", address, 54);
        }
        private static void DummyFuncMore()
        {
            string address = Constants.Address;
            string format = Constants.Format;
            Console.WriteLine(format, "Николай", "сын", address, 4);
        }
    }
}
