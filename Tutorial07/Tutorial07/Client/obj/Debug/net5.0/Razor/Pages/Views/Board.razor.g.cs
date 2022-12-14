#pragma checksum "A:\Tutorial07\Tutorial07\Client\Pages\Views\Board.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15125e68f1d5dfe58b45b499231f07f94f7a8e1e"
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
#nullable restore
#line 2 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Board.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Views/board")]
    public partial class Board : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .hbox {
        border:ridge;
        margin-left:-117px;
        margin-right:165px;
        text-align:center;
    }

    .container {
        border: ridge;
        margin-top: 5%;
        margin-left: -10%;
        padding: 10%;
        padding-left: 20%;
    }

    .box1 {
        margin-left: -15%;
        border: ridge;
        border-radius: 10px;
        height: 80px;
        margin-top: 2%;
    }


    .btn-primary {
        width: 20%;
        float: left;
        border: outset;
        margin-left: 20%;
        border-radius: 15px;
    }
    
</style>

    ");
            __builder.AddMarkupContent(1, "<div class=\"hbox\"><h3>Board</h3></div>\r\n\r\n    ");
            __builder.AddMarkupContent(2, @"<div class=""container""><div class=""box1""><p></p>
            <p><a class=""btn btn-primary"" href=""/Views/viewTickets"">Show Tickets</a></p>
            <p><a class=""btn btn-primary"" href=""/ExistingProject"">Project Dashboard</a></p></div>

        <div class=""box1""><p></p>
            <p><a class=""btn btn-primary"" href=""/Report"">Generate Report</a></p>

            <p><a class=""btn btn-primary"" href=""#"">Predict the outcome</a></p></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "A:\Tutorial07\Tutorial07\Client\Pages\Views\Board.razor"
           
        private List<Ticket> Tickets = new List<Ticket>();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Tickets = await Http.GetFromJsonAsync<List<Ticket>>("/api/Ticket");

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
