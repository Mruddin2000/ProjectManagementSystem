#pragma checksum "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6983467207a05e5feb6ab634be3ef0443403cfba"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Views/viewTickets")]
    public partial class ViewTickets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> View Tickets </h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"box1\"><p><a class=\"btn btn-primary\" href=\"/ExistingProject\">Dashboard</a></p></div>\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "table-responsive");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-hover");
            __builder.AddMarkupContent(6, "<thead class=\"thead-dark\"><tr><th>Ticket</th>\r\n                    <th>Description</th>\r\n                    <th>Edit & Assign</th>\r\n                    <th>Delete</th></tr></thead>\r\n            ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 32 "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor"
                 foreach (var ticket in Tickets)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 36 "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor"
                             ticket.TicketName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "/Details/detailsTicket/" + (
#nullable restore
#line 39 "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor"
                                                             ticket.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "/Edits/editTicket/" + (
#nullable restore
#line 42 "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor"
                                                        ticket.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/Deletes/deleteTicket/" + (
#nullable restore
#line 46 "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor"
                                                            ticket.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "A:\Tutorial07\Tutorial07\Client\Pages\Views\ViewTickets.razor"
           

        private List<Ticket> Tickets = new List<Ticket>();

        protected override async Task OnInitializedAsync()
        {

            try
            {
                Tickets = await Http.GetFromJsonAsync<List<Ticket>>("api/Ticket");
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
