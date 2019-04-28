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
            string address = "Москва, Россия";
            string format = "{0} - {1}, адрес {2}, возраст {3}";
            Console.WriteLine(format, "Петя", "школьный друг", address, 30);
        }

        private static void DummyFuncAgain()
        {
            string address = "Москва, Россия";
            string format = "{0} - {1}, адрес {2}, возраст {3}";
            Console.WriteLine(format, "Вася", "сосед", address, 54);
        }
        private static void DummyFuncMore()
        {
            string address = "Москва, Россия";
            string format = "{0} - {1}, адрес {2}, возраст {3}";
            Console.WriteLine(format, "Николай", "сын", address, 4);
        }
    }
}
