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
        }
    }
}
