using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS_Front_72190307.Services;

namespace UAS_Front_72190307.Pages
{
    public partial class DeleteStudent
    {
        [Parameter]
        public string id { get; set; }
        
        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(id));
            NavigationManager.NavigateTo("studentpage");
        }
    }
}