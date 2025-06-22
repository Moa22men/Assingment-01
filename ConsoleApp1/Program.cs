using System;

namespace ConsoleApp1
{
    internal class Program
    {
        class C1
        {
            public int v;
        }
        static void Main(string[] args)
        {
            #region Q1
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            #endregion

            #region Q2
             //string i = "7531_MMM";
             //int j = Convert.ToInt32(i);
             //Console.WriteLine(j);
            // the program will show FormatException :=> System.FormatException: 'Input string was not in a correct format.'
            #endregion

            #region Q3
            float x = 5.5f;
            float y = 1.6f;
            float result = x - y;
            Console.WriteLine(result);
            // result = 3.9
            #endregion

            #region Q4
            string s = "C# Assignment";
            string subs = s.Substring(3, 6);
            Console.WriteLine(subs);
            // Output : Assign
            #endregion

            #region Q5
            int m = 2;
            int n = m;
            n = 4;
            Console.WriteLine("a: " + m + " b: " + n);
            // M is still 2
            #endregion

            #region Q6
            C1 obj1 = new C1();
            obj1.v = 1;
            C1 obj2 = obj1;
            obj2.v = 3;
            Console.WriteLine(obj1.v);
            // obj1.v = 3
            #endregion

            #region Q7
            string H = "Hello";
            string W = "World";
            string H_W = H + " " + W;
            Console.WriteLine("Full Name: " + H_W);
            #endregion
        }
    }
}
