#pragma checksum "A:\Tutorial07\Tutorial07\Client\Pages\Deletes\DeleteTickets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4723cd546513eff0847f1edd96c36e9a9cb4decc"
// <auto-generated/>
#pragma warning disable 1591
namespace Tutorial07.Client.Pages.Deletes
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Deletes/deleteTicket/{Id:guid}")]
    public partial class DeleteTickets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .box1 {
        padding-left: 50%;
        border: ridge;
        margin-left: -25%;
        margin-top: 5%;
    }
    .box3 {
        margin-left: -25%;
        margin-top: 1%;
    }

    .box2 {
        padding: 10%;
        padding-left: 50%;
        border: ridge;
        margin-left: -25%;
    }
</style>

");
            __builder.AddMarkupContent(1, "<div class=\"box1\"><h3>Are you sure you want to delete this todo</h3></div>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"box3\"><p><a class=\"btn btn-primary\" href=\"/Views/viewTickets\">Back</a></p></div>\r\n\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "box2 ");
            __builder.AddMarkupContent(5, "<h4>Title</h4>\r\n\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 47 "A:\Tutorial07\Tutorial07\Client\Pages\Deletes\DeleteTickets.razor"
        ticket.TicketName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.AddMarkupContent(9, "<h4>Description</h4>\r\n    ");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, 
#nullable restore
#line 50 "A:\Tutorial07\Tutorial07\Client\Pages\Deletes\DeleteTickets.razor"
        ticket.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "A:\Tutorial07\Tutorial07\Client\Pages\Deletes\DeleteTickets.razor"
                                              deleteTickets

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "A:\Tutorial07\Tutorial07\Client\Pages\Deletes\DeleteTickets.razor"
       
    [Parameter]
    public Guid Id { get; set; }
    private Ticket ticket { get; set; } = new Ticket();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            ticket = await Http.GetFromJsonAsync<Ticket>($"api/Ticket/{Id}");

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch (Exception e)
        {

        }
    }
    private async void deleteTickets()
    {
        try
        {
            var response = await Http.DeleteAsync($"/api/Ticket/{ticket.Id}");
            response.EnsureSuccessStatusCode();
            Navigation.NavigateTo("/Views/viewTickets");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
