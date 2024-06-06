using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
        //count even number to recur method. 
        public static string ReturnEvenNumbers(int num)
        {
            if (num >= 100)
            {
                return ""; // Base case: Stop when num reaches 100
            }

            // Recur for the next even number
            return num + " " + ReturnEvenNumbers(num + 2);
        }

    public static void Main(string[] args)
    {
        string evenNumbers = ReturnEvenNumbers(2);
        Console.WriteLine(evenNumbers);
        Console.ReadKey();
    }

}

