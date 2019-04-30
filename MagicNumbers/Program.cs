using System;
using System.Collections.Generic;
using System.Linq;


namespace MagicNumbers
{
    
    class Program
    {
        /// <summary>
        /// Prorerties show Animal on Screen
        /// </summary>
        private static int IndexOfDisplayedAnimal =
            Constants.IndexOfDisplayedAnimal;

        static void Main(string[] args)
        {
            DoMagicNumber();
            Console.ReadKey();

        }

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

        private static void DoMagicNumber()
        {
            List<Animal> animals = GetAnimals().ToList();
            if (animals.Count > 0)
            {
                Animal displayedAnimal = animals[IndexOfDisplayedAnimal];
                Console.WriteLine($"Название: {0}, тип: {1} ,  число ног: {2}",
                    displayedAnimal.AnimalName,
                    displayedAnimal.AnimalType,
                    displayedAnimal.LegsCount);
                
            }
        }
    }
}
