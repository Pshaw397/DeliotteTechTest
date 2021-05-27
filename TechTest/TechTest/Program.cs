using System;

namespace TechTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Manual tests run in the debugger
            Console.WriteLine(NumConvert(3));
            Console.WriteLine(NumConvert(5));
            Console.WriteLine(NumConvert(7));
            Console.WriteLine(NumConvert(28));
            Console.WriteLine(NumConvert(30));
            Console.WriteLine(NumConvert(34));
        }

        public static string NumConvert(int n)
        {
            // This variable contains the result string
            string result = "";
            // This is checking if the input number if a factor of 3, and adds "Pling" to the result variable if true
            if(n % 3 == 0)
            {
                result += "Pling";
            }
            // This is checking if the input number if a factor of 5, and adds "Plang" to the result variable if true
            if (n % 5 == 0)
            {
                result += "Plang";
            }
            // This is checking if the input number if a factor of 7, and adds "Plong" to the result variable if true
            if (n % 7 == 0)
            {
                result += "Plong";
            }

            // This is checking if the result variable contains a valid value and returns the result variable if true
            if (result != "")
            {
                return result;
            }
            // If the previous if statement was false, this will return the input value as a string
            return n.ToString();
        }
    }
}
