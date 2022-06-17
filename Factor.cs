using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Factor
    {
        public void Factors_Of_Number()
        {
            Console.Write("Enter Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nFactors as below");

            for(int i = 1; i < Num; i++)
            {
                if(Num % i == 0)
                {
                    Num = Num / i;
                    Console.WriteLine(i);
                }
               
            }
                Console.WriteLine(Num); 
        }

    }
}
