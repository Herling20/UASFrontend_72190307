using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS_Front_72190307.Models;
using UAS_Front_72190307.Services;

namespace UAS_Front_72190307.Pages
{
    public partial class EnrollStudent
    {
        [Parameter]
        public string id { get; set; }

        public List<Enrollment> Enrollments {  get; set; } = new List<Enrollment>();

        [Inject]
        public IEnrollService EnrollService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Enrollments = (await EnrollService.GetAll(int.Parse(id))).ToList();
        }
    }
}