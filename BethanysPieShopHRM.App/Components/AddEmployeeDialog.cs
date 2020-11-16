using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Components
{
    public partial class AddEmployeeDialog
    {

        #region Services

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        #endregion // Services

        #region Query Parameters

        [Parameter]
        public EventCallback<bool> CloseEventCallBack { get; set; }

        #endregion // Query Parameters

        #region ViewState

        public Employee Employee { get; set; } =
            new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };

        public bool ShowDialog { get; set; }

        #endregion // ViewState

        #region Methods

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Employee = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        }

        public async Task HandleValidSubmit()
        {
            await EmployeeDataService.AddEmployee(Employee);
            ShowDialog = false;

            await CloseEventCallBack.InvokeAsync(true);
            StateHasChanged();
        }

        #endregion // Methods



    }
}
