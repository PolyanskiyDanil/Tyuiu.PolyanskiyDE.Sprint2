using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PolyanskiyDE.Sprint2.Task2.V24.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint2.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Полянский Д. Э. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Полянский Данил Эдуардович | АСОиУБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y                      *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка не находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}
