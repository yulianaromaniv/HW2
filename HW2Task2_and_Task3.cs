using System;

namespace HW2task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string str1;
            string str2;
            int a;
            int b;
            int c;
            Console.WriteLine("Input a, b, c:");
            str = Console.ReadLine();
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            a = Convert.ToInt32(str);
            b = Convert.ToInt32(str1);
            c = Convert.ToInt32(str2);
            if ((a >= b) && (a >= c))
            {
                Console.WriteLine(" max="+a);
            }
            if ((b >= a) && (b >= c))
            {
                Console.WriteLine(" max=" + b);
            }
            if ((c >= a) && (c >= b))
            {
                Console.WriteLine(" max=" + c);
            }

            if ((a <= b) && (a <= c))
            {
                Console.WriteLine(" min=" + a);
            }
            if ((b <= a) && (b <= c))
            {
                Console.WriteLine(" min=" + b);
            }
            if ((c <= a) && (c <= b))
            {
                Console.WriteLine(" min=" + c);
            }
            //task 3
            Console.WriteLine("task 3:");
            string str_;
            string str1_;
            string str2_;
            int a_;
            int b_;
            int c_;
            Console.WriteLine("Input the type of error(401, 403, 404)");
            str_ = Console.ReadLine();
            str1_ = Console.ReadLine();
            str2_ = Console.ReadLine();
            a_ = Convert.ToInt32(str_);
            b_ = Convert.ToInt32(str1_);
            c_ = Convert.ToInt32(str2_);
            if (a_ == 401)
            {
                Console.WriteLine("a=unauthorized");
            }
            if (a_ == 404)
            {
                Console.WriteLine("a=not found");
            }
            if (a_ == 403)
            {
                Console.WriteLine("a=not alloved");
            }

            if (b_ == 401)
            {
                Console.WriteLine("b=unauthorized");
            }
            if (b_ == 404)
            {
                Console.WriteLine("b=not found");
            }
            if (b_ == 403)
            {
                Console.WriteLine("b=not alloved");
            }

            if (c_ == 401)
            {
                Console.WriteLine("c=unauthorized");
            }
            if (c_ == 404)
            {
                Console.WriteLine("c=not found");
            }
            if (c_ == 403)
            {
                Console.WriteLine("c=not alloved");
            }
            

        }
    }
}
