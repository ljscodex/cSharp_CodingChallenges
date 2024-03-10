using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace ForCodingChallenges.HackerRank
{
    public class HackerRank
    {
        public static void TestHackerRank()
        {
            Console.WriteLine("Please Copy or Enter Text to test a HackerRank Challenge!");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> expenditure = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(expenditureTemp => Convert.ToInt32(expenditureTemp)).ToList();

            // If you wanna check another feature, just add a new line or change the following one.
            int result = activityNotifications(expenditure, d);

            Console.WriteLine(result);

        }

        // DAY 0: Hello World
        public static void HelloWorld() 
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
        public static void Operators()
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
        public static void solveMeFirst() 
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum =  val1 + val2;
            Console.WriteLine(sum);
        }

        //Simple Array Sum

        public static int simpleArraySum(int[] ar) {
            int iSum = 0;
            for ( int a = 0 ; a < ar.Length ; a++)
            {
                iSum = iSum + ar[a];

            }
            return iSum;
        }

        // Day 3: Intro to Conditional Statements
        public static void IntoConditionalStatements() {
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

        //A very Big Sum
        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;
            foreach( var number in ar)
            { result+= number;}
            return result;
        }


        // Array: Left Rotation
        public static List<int> rotLeft(List<int> a, int d)
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


        //Sorting: Bubble Sort
        public static void countSwaps(List<int> a)
        {

            int counter =0;
            for (int i = 0; i < a.Count; i++) 
            {

                for (int j = 0; j < a.Count - 1; j++) {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1]) {
                        int swap = a[j];
                        a[j] = a[j+1];
                        a[j+1] = swap;
                        counter+= 1;
                    }
                }
                
            }
            Console.WriteLine( $"Array is sorted in {counter} swaps.");
            Console.WriteLine( $"First Element: {a[0]}");
            Console.WriteLine( $"Last Element: {a[^1]}");   
        }

    //Mark and Toys
        public static int maximumToys(List<int> prices, int k)
        {
            int max=0;
            int isum=0;
            prices.Sort();
            for( int i=0 ; i< prices.Count; i++)
            {
                isum += prices[i];
                if ( isum > k) 
                {
                    isum-= prices[i];
                    break;
                }
            else { max = i+1; }

            }
            return max;
        }


         /*
         * Complete the 'fizzBuzz' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else { Console.WriteLine($"{i}"); }
            }
        }


        public static long repeatedString(string s, long n)
        {
            //"cfimaakj", 554045874191 == 138511468548
            //"gfcaaaecbg", 547602 == 164280
            //"beeaabc",711560125001 == 203302892858

            if (s == "a") { return n; }
            if (!s.Contains("a")) { return 0; }

            int count = s.Where(c => c == 'a').Count();
            long tmp = n / s.Length;
            int newcount = 0;

            decimal module = n % s.Length;
            if (module > 0)
            {
                string stmp = s.Substring(0, Convert.ToInt32(module) );
                newcount = stmp.Where(c => c == 'a').Count();
            }

            tmp = tmp * count;
            tmp +=  newcount;
            return tmp;
        }


        public static int activityNotifications(List<int> expenditure, int d)
        {
            Console.WriteLine("TODO! Working ON");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int counter=0;
            int i = 0;
            HashSet<int> has = expenditure.ToHashSet();
            foreach( int item in has )
            {
                var arr = has.ToList().Skip(i).Take(d);


                if (expenditure[i+d] >= (arr.Average() * 2))
                {
                    counter++;

                }
                i++;

            }
          /*  for(int i =0; i< expenditure.Count -d; i++)
            {
    //            if ( expenditure.Count -i -d > 0)
    //          {
                    //int[] arr =  new int[d];
                    //..Array.ConstrainedCopy (expenditure.ToArray(), i, arr,0, d);
                var arr = expenditure.ToList().Skip(i).Take(d);                
                // List<int> arr = expenditure.GetRange(i, d);
                    //arr.Sort();
                    if ( expenditure[i+d] >= (arr.Average() * 2) ) 
                    {
                        counter++;
                    
                    }

            } */

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Execution time: {elapsedMs/1000} seconds.");
            return counter;

        }        
    }
}