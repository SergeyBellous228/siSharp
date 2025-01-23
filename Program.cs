using System;

namespace siSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello c# ");
            System.Console.Write("hellsdfghjk ");
            System.Console.WriteLine("hello c#");

            int number = 10;
            System.Console.WriteLine(number);

            float fnumb = 11.5f;

            int f_to_int = (int)fnumb;
            string int_to_str = Convert.ToString(f_to_int);

            System.Console.WriteLine(f_to_int);

            /*
             * && - and
             * || - or 
 */

            System.Console.Write("Enter your name:");
            string inpt= Console.ReadLine();

            System.Console.WriteLine("hello " + inpt);

           int input_int = Convert.ToInt32(Console.ReadLine());

            string textResult = fnumb == 11 ? "good" : "bad";

            string formatText = $"fnumb: {fnumb}, f_to_int: {f_to_int}";

            int size = formatText.Length;


        }
    }
}
