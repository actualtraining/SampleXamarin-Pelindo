using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json;

namespace XamarinAppSample.Services
{
    public class PasienService
    {
        private HttpClient _client;
        public PasienService()
        {
            _client = new HttpClient();
        }
    }
}
