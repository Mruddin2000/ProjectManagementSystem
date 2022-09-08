#pragma checksum "A:\Tutorial07\Tutorial07\Client\Pages\Details\TicketDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b25973c5b22d7be74a1f66c9ffee9583e9764835"
// <auto-generated/>
#pragma warning disable 1591
namespace Tutorial07.Client.Pages.Details
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Details/detailsTicket/{TicketID:guid}")]
    public partial class TicketDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .box1 {
        padding-left: 50%;
        border: ridge;
        margin-top: 5%;
        margin-left: -25%;
    }
    .box3{
        margin-left:-25%;
        margin-top:1%;
    }

    .box2 {
        padding: 10%;
        padding-left: 50%;
        border: ridge;
        margin-left: -25%;
    }
</style>

");
            __builder.AddMarkupContent(1, "<div class=\"box1\"><h3>Ticket Details</h3></div>\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"box3\"><p><a class=\"btn btn-primary\" href=\"/Views/viewTickets\">Back</a></p></div>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "box2");
            __builder.AddMarkupContent(5, "<h4>Title</h4>\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 41 "A:\Tutorial07\Tutorial07\Client\Pages\Details\TicketDetails.razor"
         ticket.TicketName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<h4>Assigned project</h4>\r\n    ");
            __builder.OpenElement(10, "p");
#nullable restore
#line 45 "A:\Tutorial07\Tutorial07\Client\Pages\Details\TicketDetails.razor"
         foreach (var project in projects)
            {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, 
#nullable restore
#line 47 "A:\Tutorial07\Tutorial07\Client\Pages\Details\TicketDetails.razor"
             project.ProjectName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 47 "A:\Tutorial07\Tutorial07\Client\Pages\Details\TicketDetails.razor"
                                
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.AddMarkupContent(13, "<h4>Description</h4>\r\n    ");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, 
#nullable restore
#line 53 "A:\Tutorial07\Tutorial07\Client\Pages\Details\TicketDetails.razor"
         ticket.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "A:\Tutorial07\Tutorial07\Client\Pages\Details\TicketDetails.razor"
       
    public Guid ProjectID { get; set; }


    [Parameter]
    public Guid TicketID { get; set; }

    private List<Project> projects = new List<Project>();

    private Ticket ticket { get; set; } = new Ticket();

    private AssignTicket assignTicket { get; set; } = new AssignTicket();


    protected override async Task OnInitializedAsync()
    {
        try
        {
            ticket = await httpClient.GetFromJsonAsync<Ticket>($"api/Ticket/{TicketID}");
            assignTicket = await httpClient.GetFromJsonAsync<AssignTicket>($"/api/AssignTicket/{TicketID}");

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch (Exception e)
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591