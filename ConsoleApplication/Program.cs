using System;
using System.Configuration;
using System.Net.Http;


namespace TestApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApiURL"].ToString());
                    HttpResponseMessage response = client.GetAsync("api/HelloWorld/Print/HelloWorld").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Hello World");
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("No repsonse from API");
                        Console.Read();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
