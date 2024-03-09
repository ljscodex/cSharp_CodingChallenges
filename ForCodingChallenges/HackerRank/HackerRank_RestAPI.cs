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

    public class Datum
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string? userName { get; set; }
        public object? timestamp { get; set; }
        public string? txnType { get; set; }
        public string? amount { get; set; }
        public Location? location { get; set; }
        public string? ip { get; set; }
    }

    public class Location
    {
        public int id { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public int? zipCode { get; set; }
    }

    public class ApiDATA
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum>? data { get; set; }
    }

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
                    decimal dSum=0;
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri($"https://jsonmock.hackerrank.com/api/transactions/search?userId={userId}");
                        HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            var dData = JsonConvert.DeserializeObject<ApiDATA>(responseData);

                            foreach (var item in dData.data)
                            {
                                if (item.location.id == locationId)
                                {
                                    int iRange = int.Parse(item.ip.Split('.')[0]);

                                    if ((iRange >= netStart) && (iRange <= netEnd))
                                    {
                                        if (item.amount is not null)
                                        {
                                            dSum += Decimal.Parse(item.amount.Replace("$", string.Empty), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                                        }
                                    }

                                }
                            }

                        }
                    }

                    return Convert.ToInt32(dSum);
                }

                public int TestAPISolution()
                {
            Console.WriteLine("THIS CHALLENGE STILL IN PROGRESS!");

                    var task = HackerRank_RestAPI.getTransactions(2,8,5,150);
                    return  task.Result;
                }
        }

}
