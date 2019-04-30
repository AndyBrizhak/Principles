using System;
using System.Collections.Generic;
using System.Linq;


namespace MagicNumbers
{
    
    class Program
    {
        /// <summary>
        /// Give Collection Animals
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Animal> GetAnimals()
        {
            return new List<Animal>()
            {
                new Animal(){
                    LegsCount = 4 ,
                    AnimalType = "Млекопитающие" ,
                    AnimalName = "Собака"
                }
                , new Animal(){
                    LegsCount = 4 ,
                    AnimalType = "Млекопитающие" ,
                    AnimalName = "Корова"
                }
                , new Animal(){
                    LegsCount = 2 ,
                    AnimalType = "Птицы" ,
                    AnimalName = "Утка"
                }
            };
        }

        static void Main(string[] args)
        {
            DoMagicNumber();
            Console.ReadKey();

        }

        private static void DoMagicNumber()
        {
            List<Animal> animals = GetAnimals().ToList();
            if (animals.Count > 0)
            {
                Console.WriteLine($"Название: {0}, тип: {1} ,  число ног: {2}",
                                    animals[1].AnimalName,
                                    animals[1].AnimalType,
                                    animals[1].LegsCount);
                
            }
        }
    }
}
