
using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;

            //ask the user to input a number and store the value of the number in n
            Console.Write("Enter a number and I will print out its reverse: ");
            n = Convert.ToInt32(Console.ReadLine());

            //while the value of n is greater than o
            while(n > 0)
            {
                //the value of r begins the remainder of what is left when you divide n by 10
                r = n % 10;

                //print out the result
                //Use Console.Write as Console.WriteLine creates a new line
                Console.Write(r);
                n = n/10;
            }
           
        }
    }
}
