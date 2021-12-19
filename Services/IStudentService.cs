using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_Front_72190307.Models;

namespace UAS_Front_72190307.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();

        Task<Student> GetById(int id);

        Task<Student> Add(Student student);

        Task<Student> Update(int id, Student student);

        Task Delete(int id);
    }
}