using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json;
using XamarinAppSample.Models;
using XamarinAppSample.Helper;

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
            var strUri = MyHelper.ApiUrl + "api/Pasien";
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

        public async Task Insert(Pasien pasien)
        {
            var strUri = MyHelper.ApiUrl + "api/Pasien";
            var newItem = JsonConvert.SerializeObject(pasien);
            var content = new StringContent(newItem, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await _client.PostAsync(strUri, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error : Tambah data gagal " + response.StatusCode);
            }
        }

        public async Task Update(Pasien pasien)
        {
            var strUri = MyHelper.ApiUrl + "api/Pasien";
            var editItem = JsonConvert.SerializeObject(pasien);
            var content = new StringContent(editItem, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await _client.PutAsync(strUri, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error : update data gagal " + response.StatusCode);
            }
        }


    }
}
