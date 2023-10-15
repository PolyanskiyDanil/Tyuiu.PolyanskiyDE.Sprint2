using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyanskiyDE.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string num;
            switch (value1)
            {
                case 1:
                    num = "пик";
                    break;
                case 2:
                    num = "треф";
                    break;
                case 3:
                    num = "бубен";
                    break;
                case 4:
                    num = "черви";
                    break;
                default:
                    throw new ArgumentException($"Масть должна быть от 1 до 4. Значение {value1}");
            }

            string card;

            switch (value2)
            {
                case 6:
                    card = "Шестерка";
                    break;
                case 7:
                    card = "Семерка";
                    break;
                case 8:
                    card = "Восьмерка";
                    break;
                case 9:
                    card = "Девятка";
                    break;
                case 10:
                    card = "Десятка";
                    break;
                case 11:
                    card = "Валет";
                    break;
                case 12:
                    card = "Дама";
                    break;
                case 13:
                    card = "Король";
                    break;
                case 14:
                    card = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Достоинство карты должно быть от 6 до 14. Значение {value2}");

            }

            return card + " " + num;
        }
    }
}
