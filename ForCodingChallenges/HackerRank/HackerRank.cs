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

        static void simpleArraySum() 
        {
            TextWriter textWriter = new StreamWriter( AppDomain.CurrentDomain.BaseDirectory , true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySumSub(ar);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
            }    


           // Day 3: Intro to Conditional Statements
        static void IntoConditionalStatements() {
            int N = Convert.ToInt32(Console.ReadLine());
            // check event or odd
            if (N % 2 == 0)
            {
                if ( N >= 2 && N  <= 5)
                {
                        Console.WriteLine( "Not Weird");  }
                else if (N >= 6 && N <= 20) {
                        Console.WriteLine( "Weird"); }
                else if (N > 20)
                    {
                        Console.WriteLine("Not Weird"); }
            }
            else
            {
                            Console.WriteLine( "Weird");

            }
        }


        public static string ConditionalStatements( int N)
        {
            if ( N <= 0 || N > 100) { return "Not Weird"; }
            // check event or odd
            if (N % 2 == 0)
            {
                if ( N >= 2 && N  <= 5) {
                            return "Not Weird"; }
                else if (N >= 6 && N <= 10) {
                        return "Weird"; }
                else if (N > 20)
                    { return "Not Weird"; }
            }
            else  {  return "Weird";  }
            return "Not Weird";
        }

        //Sales by Match
          /*
        * Complete the 'sockMerchant' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER n
        *  2. INTEGER_ARRAY ar
        */

        public static int sockMerchant(int n, List<int> ar)
        {
        
            int iPairs = 0;
            var Lista = (from obj in ar
                        select obj).Distinct().ToList();
                            
            foreach ( var sobj in Lista) 
            {
                var imod = (from ob2 in ar  
                                where ob2.Equals(sobj)
                            select ob2).Count()/2;
                            
                iPairs = iPairs + imod;    
            }               
                            
            return iPairs;
        }

        public static void SalesByMatch(string[] args)
        {
            TextWriter textWriter = new StreamWriter( AppDomain.CurrentDomain.BaseDirectory, true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

    }
}