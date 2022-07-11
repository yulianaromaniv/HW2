using System;
using System.Globalization;
namespace HW2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string str1;
            string str2;
            float a;
            float b;
            float c;
            Console.WriteLine("Input a, b, c: (in format 3,555)");
            str = Console.ReadLine();
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            /*NunberFormatInfo nunberFormatInfo = new NunberFormatInfo()
            {

            }*/

            a = Convert.ToSingle(str);
            b = Convert .ToSingle(str1);
            c =  Convert.ToSingle(str2);
            if(((a<=5.0)&&(a>=-5.0))&&((b <= 5.0) && (b >= -5.0))&& ((c <= 5.0) && (c >= -5.0)))
            {
                Console.WriteLine("a=" + a + " b=" + b + " c=" + c);
            }
            else
            {
                Console.WriteLine("The condition is not satisfied.");
            }
        }
    }
}
