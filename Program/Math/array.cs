using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Math
{
    class Arrayy
    {
        public void test()
        {
            var numbers = new int[3] { 1, 2, 3 };
            var list = string.Join(",", numbers);
            Console.WriteLine(list);
        }
    }
}

