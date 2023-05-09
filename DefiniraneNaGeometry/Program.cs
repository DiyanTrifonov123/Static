using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи страна: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Въведи a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведи b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Въведи радиус: ");
            double radius = double.Parse(Console.ReadLine());

            double squarePerimeter = Geometry.SquarePerimeter(side);
            double squareArea = Geometry.SquareArea(side);
            double rectanglePerimeter = Geometry.RectanglePerimeter(a, b);
            double rectangleArea = Geometry.RectangleArea(a, b);
            double circleArea = Geometry.CircleArea(radius);

            Console.WriteLine($"Квадрат: периметър = {squarePerimeter}см, лице = {squareArea}см");
            Console.WriteLine($"Правоъгълник: периметър = {rectanglePerimeter}см, лице = {rectangleArea}см");
            Console.WriteLine($"Кръг: лице = {circleArea}см");
        }
    }
}
