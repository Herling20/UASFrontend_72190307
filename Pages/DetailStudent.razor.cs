using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS_Front_72190307.Models;
using UAS_Front_72190307.Services;

namespace UAS_Front_72190307.Pages
{
    public partial class DetailStudent
    {
        [Parameter]
        public string id { get; set; }

        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetById(int.Parse(id));

        }
    }
}