using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace ForCodingChallenges.HackerRank
{
    public class HackerRank
    {
        

        // DAY 0: Hello World
        static void HelloWorld() 
        {
            // Declare a variable named 'inputString' to hold our input.
            String? inputString; 
            
            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine(); 
            
            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");
            Console.WriteLine(inputString);

        }

        //Day 2: Operators
        static void Operators()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());
            
            double result=0;
            result = meal_cost;
            result +=  meal_cost * tip_percent /100;
            result +=  meal_cost * tax_percent/ 100;
            Console.WriteLine(Math.Round( result, 0));
        }

       //Solve Me First
        static void solveMeFirst() 
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum =  val1 + val2;
            Console.WriteLine(sum);
        }

        //Simple Array Sum

    static int simpleArraySumSub(int[] ar) {
        int iSum = 0;
        for ( int a = 0 ; a < ar.Length ; a++)
        {
            iSum = iSum + ar[a];

        }
        return iSum;
    }

    static void simpleArraySum() {
        TextWriter textWriter = new StreamWriter( AppDomain.CurrentDomain.BaseDirectory , true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = simpleArraySumSub(ar);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }    
    }
}