using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible
{
    public class Divisible : IDivisibleByX, IDivisibleByXY
    {
        

        public  bool divide(int number, int x, String message)
        {
            if(number%x==0)
            {
                Console.WriteLine(message);
                return true;
            }
            return false;
        }

        public bool divide(int number, int x, int y, string message)
        {
            if (number % x == 0 && number % y == 0)
            {
                Console.WriteLine(message);
                return true;
            }
            return false;
        }
    }
}
