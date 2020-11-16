#pragma checksum "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5e61a8cf68ac982507d83d4705170bdb95c1b88"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All Employees</h1>");
#nullable restore
#line 6 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
 if (Employees == null)
{
    // Spinner example 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner-border text-primary\" role=\"status\"><span class=\"sr-only\">Testing...</span></div>");
#nullable restore
#line 12 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th></th>\r\n                <th>Employee Id</th>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 26 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 29 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                    $"https://gillcleerenpluralsight.blob.core.windows.net/person/{employee.EmployeeId}-small.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "rounded-circle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 30 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                         employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 31 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 32 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", 
#nullable restore
#line 34 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                   $"employeedetail/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(25, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 37 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                   $"employeeedit/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(30, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                  QuickAddEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "btn btn-dark table-btn quick-add-btn");
            __builder.AddContent(34, "  +  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenComponent<BethanysPieShopHRM.App.Components.AddEmployeeDialog>(36);
            __builder.AddAttribute(37, "CloseEventCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 48 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                                                 AddEmployeeDialog_OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 48 "C:\Users\micha\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                         AddEmployeeDialog = (BethanysPieShopHRM.App.Components.AddEmployeeDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
