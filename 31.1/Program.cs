using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            while (true)
            {
                Console.WriteLine("1. Добавить фигуру\n2. Показать все фигуры\n3. Изменить фигуру\n4. Удалить фигуру\n5. Вызвать метод фигуры\n6. Выйти");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Выберите фигуру: 1. Прямоугольник 2. Квадрат 3. Круг 4. Треугольник");
                        string figureChoice = Console.ReadLine();
                        Figure figure = null;
                        switch (figureChoice)
                        {
                            case "1":
                                Console.Write("Введите стороны: ");
                                figure = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                                break;
                            case "2":
                                Console.Write("Введите сторону квадрата: ");
                                figure = new Square(double.Parse(Console.ReadLine()));
                                break;
                            case "3":
                                Console.Write("Введите радиус: ");
                                figure = new Circle(double.Parse(Console.ReadLine()));
                                break;
                            case "4":
                                Console.Write("Введите стороны: ");
                                figure = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                                break;
                            default:
                                Console.WriteLine("Неверный выбор!");
                                return;
                        }
                        figures.Add(figure);
                        Console.WriteLine("Фигура добавлена!");
                        break;
                    case "2":
                        for (int i = 0; i < figures.Count; i++)
                            Console.WriteLine($"{i + 1}. {figures[i].Name}");
                        break;
                    case "3":
                        Console.Write("Выберите номер фигуры: ");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        if (figures[index] is Rectangle rect)
                        {
                            Console.Write("Введите новые стороны: ");
                            rect.Side1 = double.Parse(Console.ReadLine());
                            rect.Side2 = double.Parse(Console.ReadLine());
                        }
                        else if (figures[index] is Circle circle)
                        {
                            Console.Write("Введите новый радиус: ");
                            circle.Radius = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Фигура изменена!");
                        break;
                    case "4":
                        Console.Write("Выберите номер фигуры для удаления: ");
                        int deleteIndex = int.Parse(Console.ReadLine()) - 1;
                        figures.RemoveAt(deleteIndex);
                        Console.WriteLine("Фигура удалена!");
                        break;
                    case "5":
                        Console.Write("Выберите номер фигуры: ");
                        int methodIndex = int.Parse(Console.ReadLine()) - 1;
                        figures[methodIndex].Print();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод!");
                        break;
                }
            }
        }
    }
}
