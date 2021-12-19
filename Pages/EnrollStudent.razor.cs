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

        public Enrollment Enrollments {  get; set; } = new Enrollment();

        [Inject]
        public IEnrollService EnrollService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Enrollments = await EnrollService.GetById(int.Parse(id));
        }
    }
}