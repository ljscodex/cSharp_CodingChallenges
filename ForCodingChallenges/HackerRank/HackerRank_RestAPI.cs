using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ForCodingChallenges.HackerRank
{
    public class HackerRank_RestAPI
        {

                /*
                 * Complete the 'getTransactions' function below.
                 *
                 * The function is expected to return an INTEGER.
                 * The function accepts following parameters:
                 *  1. INTEGER userId
                 *  2. INTEGER locationId
                 *  3. INTEGER netStart
                 *  4. INTEGER netEnd
                 *
                 *  https://jsonmock.hackerrank.com/api/transactions/search?userId=
                 */


                public static async Task<int> getTransactions(int userId, int locationId, int netStart, int netEnd)
                {
                    int results = 0;


                    // i has to open the door for my kids.

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri($"https://jsonmock.hackerrank.com/api/transactions/search?userId={userId}");
                        HttpResponseMessage response = await client.GetAsync(client.BaseAddress);


                        string responseData = await response.Content.ReadAsStringAsync();
                        // i will use postman to get JSON structure.
                        // need to go to see the "pizza"
                        JObject dData = (JObject)JsonConvert.DeserializeObject(responseData);

                        foreach (var row in dData)
                        {
                            if (row.Value.Count() > 1) // does it has values ?
                            {
                                Dictionary<string, object> checkObj = JsonConvert.DeserializeObject<Dictionary<string, object>(row.Value.ToString());

                                // i need to go!.
                                foreach (var info in checkObj)
                                {
                                    Console.WriteLine($"Data: {info.ToString()}");
                                }
                            }
                        }
                        results = 1;


                    }

                    return results;
                }

            }

       public  class Solution
            {
                public static void Main(string[] args)
                {
            Console.WriteLine("THIS CHALLENGE STILL IN PROGRESS!");
                    int userId = Convert.ToInt32(Console.ReadLine().Trim());

                    int locationId = Convert.ToInt32(Console.ReadLine().Trim());

                    int netStart = Convert.ToInt32(Console.ReadLine().Trim());

                    int netEnd = Convert.ToInt32(Console.ReadLine().Trim());

                    var task = HackerRank_RestAPI.getTransactions(userId, locationId, netStart, netEnd);
                    var result = task.Result;
                }
            }

}
