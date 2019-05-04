using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine($"customer Id {customer.Id}");
            Console.ReadKey();

            Store store = new Store();
            Console.WriteLine($"Store Id {store.Id}");
            Console.ReadKey();
        }
    }
}
