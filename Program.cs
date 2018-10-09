using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisible div3 = new Divisible();

            for (int number=1;number<=100;number++)
            {
                
                if (!div3.divide(number, 3, 5,"FizzzBuzzz"))
                    if (!div3.divide(number, 3,"Fizzzz"))
                        if (!div3.divide(number, 5,"Buzzz"))
                            div3.divide(number, 7,"Wooo");

            }
            Console.ReadLine();
        }
    }
}
