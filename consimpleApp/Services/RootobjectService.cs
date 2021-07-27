using consimpleApp.Models;
using consimpleApp.View;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace consimpleApp.Services
{
    public class RootobjectService : IRootobjectService
    {
        private const string BaseUrl = "http://tester.consimple.pro";
        private readonly HttpClient _client;
       

        public RootobjectService(HttpClient client)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Rootobject> GetAllAsync()
        {
            HttpResponseMessage response = await _client.GetAsync(BaseUrl);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }
            dynamic result = await response.Content.ReadAsStringAsync();
            Rootobject rootObject = JsonConvert.DeserializeObject<Rootobject>(result);
          
             var selected = from category in rootObject.Categories
                       join prod in rootObject.Products on category.Id equals prod.CategoryId
                       select new { Name = prod.Name, Category = category.Name };
            DisplayTable.Display("Product Name", "Category", selected);
            return rootObject;
        }
    }
}
