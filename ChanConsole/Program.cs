using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ChanConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:54281/api/");
                var response = client.GetAsync("Greetings/Greet").Result;
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
