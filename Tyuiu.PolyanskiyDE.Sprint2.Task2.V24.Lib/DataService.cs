using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyanskiyDE.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 4))
                res = true;
            if ((x >= 9) && (x <= 12) && (y >= 3) && (y <= 6))
                res = true;
            if ((x >= 6) && (x <= 8) && (y >= 5) && (y <= 10))
                res = true;
            if ((x == 13) && (y == 6))
                res = true;
            if ((x >= 9) && (x <= 12) && (y >= 9) && (y <= 10))
                res = true;
            if ((x >= 3) && (x <= 7) && (y == 11))
                res = true;
            if ((x >= 11) && (x <= 12) && (y >= 11) && (y <= 12))
                res = true;
            if ((x == 7) && (y == 12))
                res = true;


            return res;
        }
    }
}
