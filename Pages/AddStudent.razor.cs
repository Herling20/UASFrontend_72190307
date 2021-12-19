using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS_Front_72190307.Models;
using UAS_Front_72190307.Services;

namespace UAS_Front_72190307.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task HandleValidSubmit(){
            var result = await StudentService.Add(Student);
            NavigationManager.NavigateTo("studentpage");
        }
    }
}