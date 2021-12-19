using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_Front_72190307.Services;
using UAS_Front_72190307.Models;
using Microsoft.AspNetCore.Components;

namespace UAS_Front_72190307.Pages
{
    public partial class StudentPage
    {
        public List<Student> Students {  get; set; } = new List<Student>();

        [Inject]
        public IStudentService StudentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAll()).ToList();
        }
    }
}