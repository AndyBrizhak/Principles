using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
           var xList = GetAllFigures();
           var area= CalculateFiguresArea(xList);
            Console.WriteLine(area);
            Console.ReadKey();

        }

        private static List<Figure> GetAllFigures()
        {
            var figures = new List<Figure>();
            figures.Add(new Triangle() { Base = 7, Height = 7 });
            figures.Add(new Square() { Side = 9 });
            figures.Add(new Triangle() { Base = 19, Height = 8 });
            figures.Add(new Square() { Side = 33 });
            return figures;
        }

        private static double CalculateFiguresArea(List<Figure> figures)
        {
            double area = 0.0;
            foreach (var figure in figures)
            {
                //if (figure is Triangle)
                //{
                //    Triangle triangle = figure as Triangle;
                //    area += (triangle.Base * triangle.Height) / 2;
                //}
                //else if (figure is Square)
                //{
                //    Square square = figure as Square;
                //    area += square.Side * square.Side;
                //}

                area += figure.CalculateArea();
            }
            return area;
        }

    }
}
