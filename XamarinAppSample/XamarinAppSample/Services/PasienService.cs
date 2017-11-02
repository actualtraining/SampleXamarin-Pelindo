using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json;
using XamarinAppSample.Models;

namespace XamarinAppSample.Services
{
    public class PasienService
    {
        private HttpClient _client;
        public PasienService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Pasien>> GetAll()
        {
            var strUri = "http://pelindo3.azurewebsites.net/api/Pasien";
            var response = await _client.GetAsync(strUri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Pasien>>(content);
                return data;
            }
            else
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }
    }
}
