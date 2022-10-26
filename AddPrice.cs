using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Calculator
    {
        public static int Add(int tal1, int tal2)
        {
            int result = tal1 + tal2;
            return result;
        }
        public static int Mult(int tal1, int tal2)
        {
            int result = tal1 * tal2;
            return result;
        }
        public static int Add2(int tal1, int tal2, int tal3)
        {
            int result = tal1 + tal2 + tal3;
            return result;
        }

    }
}
