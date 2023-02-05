using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class QuotientRemainder
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, num;
            Console.WriteLine("enter Dividend",n1);
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Divisor",n2);
            num=int.Parse(Console.ReadLine());
            n3 = n1 % n2;
            Console.WriteLine("Remainder is:",n3);




                
        }
    }
}
