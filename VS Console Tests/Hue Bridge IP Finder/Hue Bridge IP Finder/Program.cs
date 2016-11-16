using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Newtonsoft.Json.Linq;

namespace Hue_Bridge_IP_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            String JSONreturn;
            Int32 BridgeNo = 1;
 
            JSONreturn = GET("https://www.meethue.com/api/nupnp");
            Console.WriteLine(JSONreturn);

            JArray a = JArray.Parse(JSONreturn);
            Console.WriteLine("Bridges = " + a.Count);

            if (a.Count != 0)
            {
                if (BridgeNo > a.Count || BridgeNo <= 0)
                {
                    Console.WriteLine("Bridge does not exist! Returning first!");
                    BridgeNo = 1;
                }

                BridgeNo = BridgeNo - 1;

                Console.WriteLine(a[BridgeNo]);

                string internalipaddress = (string)a[0]["internalipaddress"];
                Console.WriteLine("IP Address = " + internalipaddress);
            }
            else
            {
                Console.WriteLine("No bridge detected - enter IP manually");
            }
            

            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }

        static string GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }
    }
}
