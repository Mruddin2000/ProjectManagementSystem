#pragma checksum "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ebc1507291fe2c49818e57fb6d785d06a66a036"
// <auto-generated/>
#pragma warning disable 1591
namespace Tutorial07.Client.Pages.Views
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Tutorial07.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Tutorial07.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Tutorial07.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "A:\Tutorial07\Tutorial07\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Report")]
    public partial class Report : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Report</h3>\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(1, @"<style>
        h3 {
            margin-left: 35%;
        }

        .tableBox {
            width: 25%;
            float: left;
            margin-left: -4%;
            margin-top: 5%;
            margin-right: 10%;
            border: ridge;
        }
    </style>
    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "tableBox");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "table-responsive");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-hover");
            __builder.AddMarkupContent(8, "<thead class=\"thead-dark\"><tr><th>Ticket</th></tr></thead>\r\n                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 32 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                     foreach (var ticket in Tickets)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 36 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                                 ticket.TicketName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "tableBox");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "table-responsive");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-hover");
            __builder.AddMarkupContent(20, "<thead class=\"thead-dark\"><tr><th>Company</th></tr></thead>\r\n                ");
            __builder.OpenElement(21, "tbody");
#nullable restore
#line 57 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                     foreach (var company in Companies)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 61 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                                 company.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "tableBox");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "table-responsive");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "table table-hover");
            __builder.AddMarkupContent(32, "<thead class=\"thead-dark\"><tr><th>Project</th></tr></thead>\r\n                ");
            __builder.OpenElement(33, "tbody");
#nullable restore
#line 82 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                     foreach (var project in Projects)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 86 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                                 project.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Report.razor"
           
        private List<Ticket> Tickets = new List<Ticket>();
        private List<Project> Projects = new List<Project>();
        private List<Company> Companies = new List<Company>();



        protected override async Task OnInitializedAsync()
        {

            try
            {
                Tickets = await Http.GetFromJsonAsync<List<Ticket>>("api/Ticket");
                Projects = await Http.GetFromJsonAsync<List<Project>>("api/Project");
                Companies = await Http.GetFromJsonAsync<List<Company>>("/api/Company");


            }
            catch (Exception)
            {

                throw;
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
