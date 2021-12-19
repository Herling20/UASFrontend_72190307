using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using UAS_Front_72190307.Models;

namespace UAS_Front_72190307.Services
{
    public class StudentService : IStudentService
    {
        HttpClient _httpClient;

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task <IEnumerable<Student>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Student>>("api/Student");
            return result;
        }

        public async Task<Student> GetById(int id)
        {
            var results = await _httpClient.GetFromJsonAsync<Student>($"api/Student/{id}");
            return results;
        }

        public async Task<Student> Add(Student obj){
            var response = await _httpClient.PostAsJsonAsync($"api/Student", obj);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception("Gagal tambah data Student");
            }
        }

        public async Task<Student> Update(int id, Student student)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Student/{id}", student);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync());
            }
            else
            {
                throw new Exception("Gagal Update Employee");
            }
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/Student/{id}");
        }        
    }
}