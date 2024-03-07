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
        public void HelloWorld() 
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
        public void Operators()
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
        public void solveMeFirst() 
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum =  val1 + val2;
            Console.WriteLine(sum);
        }

        //Simple Array Sum

        public int simpleArraySum(int[] ar) {
            int iSum = 0;
            for ( int a = 0 ; a < ar.Length ; a++)
            {
                iSum = iSum + ar[a];

            }
            return iSum;
        }

        // Day 3: Intro to Conditional Statements
        public void IntoConditionalStatements() {
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
                    {   Console.WriteLine("Not Weird"); }
            }
            else
            {
                Console.WriteLine( "Weird");

            }
        }


        public string ConditionalStatements( int N)
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

        public int sockMerchant(int n, List<int> ar)
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

        //A very Big Sum
        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;
            foreach( var number in ar)
            { result+= number;}
            return result;
        }


        // Array: Left Rotation
        public  List<int> rotLeft(List<int> a, int d)
        {
            if ( d == a.Count()) { return a; }
            if ( a.Count() ==1 ) { return a; }
            
            int[] arra  = a.ToArray();
            
            for ( int ir = 1; ir <= d; ir++)        
            {
                int tmp = arra[0];
                Array.Copy(arra, 1, arra, 0, arra.Length - 1);
                arra[^1] = tmp;

            }
            return arra.ToList();   
        }




    }
}