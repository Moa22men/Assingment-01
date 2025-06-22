using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            #endregion

            #region Q2
            string i = "7531_MMM";
            int j = Convert.ToInt32(i);
            Console.WriteLine(j);
            // the program will show FormatException :=> System.FormatException: 'Input string was not in a correct format.'
            #endregion
        }
    }
}
