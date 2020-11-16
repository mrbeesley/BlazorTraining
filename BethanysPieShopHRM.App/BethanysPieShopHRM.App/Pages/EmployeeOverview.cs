using BethanysPieShopHRM.App.Components;
using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        #region Services

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        #endregion // Services

        #region QueryParameters
        #endregion // QueryParameters

        #region ViewState

        public IEnumerable<Employee> Employees { get; set; }

        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        #endregion // ViewState

        #region Methods

        protected override async Task OnInitializedAsync()
        {
            await LoadState(true);
        }

        protected async Task LoadState(bool updateScreen)
        {
            Employees = await EmployeeDataService.GetAllEmployees();
            if (updateScreen)
                StateHasChanged();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            await LoadState(true);
        }

        #endregion // methods


    }
}
