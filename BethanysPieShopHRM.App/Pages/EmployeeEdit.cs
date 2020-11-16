using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeEdit
    {
        #region Services

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Inject]
        public ICountryDataService CountryDataService { get; set; }

        [Inject]
        public IJobCategoryDataService JobCategoryDataService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        #endregion // Services

        #region State

        [Parameter]
        public string EmployeeId { get; set; }

        // This is important if you let this default to null it will break the app on initial load
        public Employee Employee { get; set; } = new Employee();

        public IEnumerable<Country> Countries { get; set; } = new List<Country>();

        public IEnumerable<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

        protected string CountryId = string.Empty;

        protected string JobCategoryId = string.Empty;

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        #endregion // State

        #region Methods

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            int.TryParse(EmployeeId, out int employeeId);
            if(employeeId == 0)
            {
                Employee = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
            }
            else
            {
                Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            }

            Countries = (await CountryDataService.GetAllCountries()).ToList();
            JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();
            CountryId = Employee.CountryId.ToString();
            JobCategoryId = Employee.JobCategoryId.ToString();
        }

        protected async Task HandleValidSubmit()
        {
            Employee.CountryId = int.Parse(CountryId);
            Employee.JobCategoryId = int.Parse(JobCategoryId);

            if(Employee.EmployeeId == 0)
            {
                var addedEmployee = EmployeeDataService.AddEmployee(Employee);
                if(addedEmployee != null)
                {
                    StatusClass = "alert-succes";
                    Message = "New Employee Added Successfully!";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong adding the new employee, please try again.";
                    Saved = false;
                }
            }
            else
            {
                await EmployeeDataService.UpdateEmployee(Employee);
                StatusClass = "alert-succes";
                Message = "Employee Saved Successfully!";
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "Please fix validation issues and try again.";
        }

        protected async Task DeleteEmployee()
        {
            await EmployeeDataService.DeleteEmployee(Employee.EmployeeId);
            StatusClass = "alert-success";
            Message = "Employee was deleted successfully.";
            Saved = true;
        }

        protected void NaviateToOverview()
        {
            Navigation.NavigateTo("/employeeoverview");
        }

        #endregion // Methods

    }
}
