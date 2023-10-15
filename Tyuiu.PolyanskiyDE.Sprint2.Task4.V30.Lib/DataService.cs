using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyanskiyDE.Sprint2.Task4.V30.Lib
{
    public class DataService : ISprint2Task4V30
    {
        public double Calculate(double x, double y)
        {
            double z = x * 2 > y ? (Math.Pow(6 + (4 / (Math.Pow(x, 2))), y)) : y + (2 / (Math.Pow(x, 2)));
            return Math.Round(z, 3);
        }
    }
}
