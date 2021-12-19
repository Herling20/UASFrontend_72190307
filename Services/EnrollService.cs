using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UAS_Front_72190307.Models;

namespace UAS_Front_72190307.Services
{
    public class EnrollService : IEnrollService
    {
        HttpClient _httpClient;

        public EnrollService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task <IEnumerable<Enrollment>> GetAll(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Enrollment>>($"enrollment/{id}");
            return result;
        }
    }
}