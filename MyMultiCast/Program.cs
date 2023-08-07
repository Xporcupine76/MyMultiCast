using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace MyMultiCast
{

    class Program
    {
        delegate void del(int x, int y); 

        static void Main(string[] args)
        {
 /*           Mark mark = new Mark();
            mark.AddNumbers(3, 3);
            mark.MultiplyNumbers(3, 3);
            mark.SubtractNumbers(4, 3);
 */           
           Mark mark = new Mark();
            del d;

            d = mark.AddNumbers;
            Console.WriteLine("invoking delegat d with one target: ");
            d(6, 5);
            Console.WriteLine();

            d += mark.MultiplyNumbers;
            Console.WriteLine("invoking delegat d with two targets: ");
            d(6, 5);
            Console.WriteLine();

            d += mark.SubtractNumbers;
            Console.WriteLine("invoking delegat d with three targets: ");
            d(6, 5);
            Console.WriteLine();

            d -= mark.MultiplyNumbers;
            Console.WriteLine("invoking delegat d without Multiplers: ");
            d(6, 5);
            Console.WriteLine();
        }
    }
    public class Mark
    {

        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("AddNumbers: a+b = " + (a + b));

        }
        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine("MultiplyNumbers: a+b = " + (a * b));

        }
        public void SubtractNumbers(int a, int b)
        {
            Console.WriteLine("SubtractNumbers: a+b = " + (a - b));

        }


    }
}
