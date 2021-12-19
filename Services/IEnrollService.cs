using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_Front_72190307.Models;

namespace UAS_Front_72190307.Services
{
    public interface IEnrollService
    {
        Task<IEnumerable<Enrollment>> GetAll(int id);
        
    }
}