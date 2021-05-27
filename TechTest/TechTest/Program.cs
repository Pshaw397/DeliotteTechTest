using System;

namespace TechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumConvert(3));
            Console.WriteLine(NumConvert(5));
            Console.WriteLine(NumConvert(7));
            Console.WriteLine(NumConvert(28));
            Console.WriteLine(NumConvert(30));
            Console.WriteLine(NumConvert(34));
        }

        static string NumConvert(int n)
        {
            string result = "";
            if(n % 3 == 0)
            {
                result += "Pling";
            }
            if (n % 5 == 0)
            {
                result += "Plang";
            }
            if (n % 7 == 0)
            {
                result += "Plong";
            }
            
            if(result != "")
            {
                return result;
            }
            return n.ToString();
        }
    }
}
