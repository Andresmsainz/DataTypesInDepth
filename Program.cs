using System;

namespace DataTypesInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 0;
            x = int.MaxValue;
            Console.WriteLine("x = " + x);

            int y = 2147483647;
            Console.WriteLine("y = " + y);

            float f_no = 0.0f;
            double d_no = 0.0d;
            decimal m_no = 0.0m;

            f_no = 1 / 3f;
            d_no = 1 / 3d;
            m_no = 1 / 3m;

            Console.WriteLine("f_no = " + f_no);
            Console.WriteLine("d_no = " + d_no);
            Console.WriteLine("m_no = " + m_no);


        }
    }
}
