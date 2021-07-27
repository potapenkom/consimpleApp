using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;
using consimpleApp.Models;
using consimpleApp.Services;

namespace consimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Get data via WebAPI? Press Y or N");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Y":
                    HttpClient client = new HttpClient();
                    RootobjectService rootobjectService = new RootobjectService(client);
                    rootobjectService.GetAllAsync().Wait();
                    break;
                case "N":
                    break;
                default:
                    Console.WriteLine("You pressed an unknown letter");
                    break;
            }
           
        }

    }
}