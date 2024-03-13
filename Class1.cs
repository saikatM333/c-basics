using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            int a = 12;
            long l = 1224394L;

            float f = 1234.44F;
            double d = 1233344.4444D;
            char c = 'a';
            string s = "saikat heloo";

            const int n = 12;

            // n= 12 will give error as const canot be changed 

            Console.WriteLine(a);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.WriteLine(n);

            int age = 21;

            if (age > 18)
            {
                Console.WriteLine("you are qulified for voting ");
            }
            else
            {
                Console.WriteLine("you are qulified for not voting ");

            }

            int x = 100;
            int sum = 0;

            for (int i = 0; i < x;  i++)
            {
                sum = sum + i;
            }

            Console.WriteLine(sum);


            int j = 0;
            while (sum > 0)
            {
                sum = sum - j;

                j = j + 3;

            }

            Console.WriteLine(sum);
        }
    }
}
