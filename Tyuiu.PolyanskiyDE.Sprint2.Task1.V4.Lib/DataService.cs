using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;   // False, False, False, False, True, False a = 175, b = 176, c = 414, d = 414

namespace Tyuiu.PolyanskiyDE.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c < d); // 175 == 176 414 < 414
            res[1] = (a < b) & (c != d); // 175 < 176 414 == 414
            res[2] = (a == b) || (c < d); // 175 == 176 414 < 414
            res[3] = (a < b) && (c != d); // 175 < 176 414 == 414
            res[4] = !(res[0]);
            res[5] = (a > b) ^ (c != d); // 175 > 176 414 != 414

            return res;
        }
    }
}
