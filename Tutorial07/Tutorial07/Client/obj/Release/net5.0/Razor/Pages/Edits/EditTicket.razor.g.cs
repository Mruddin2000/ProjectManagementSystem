#pragma checksum "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d5c6249ba6c715109835b661d73273ef9bc6c6a"
// <auto-generated/>
#pragma warning disable 1591
namespace Tutorial07.Client.Pages.Edits
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edits/editTicket/{TicketID:guid}")]
    public partial class EditTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .box1 {
        padding-left: 50%;
        border: ridge;
        margin-left: -25%;
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

    .assign {
        margin-left: -65%;
        margin-top: 5%;
    }

        .assign .btn-primary {
            margin-top: 5%;
            margin-left: 45%;
        }
</style>


");
            __builder.AddMarkupContent(1, "<div class=\"box1\"><h3>Edit your Tickets</h3></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"box3\"><p><a class=\"btn btn-primary\" href=\"/Views/viewTickets\">Back</a></p></div>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "box2");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 53 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                     ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 53 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label class=\"control-label\">Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                    ticket.TicketName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.TicketName = __value, ticket.TicketName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.TicketName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.Tutorial07.Client.Pages.Edits.EditTicket.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 59 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                      ()=>ticket.TicketName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label class=\"control-label\">Description</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                    ticket.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Description = __value, ticket.Description))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.Tutorial07.Client.Pages.Edits.EditTicket.TypeInference.CreateValidationMessage_1(__builder2, 30, 31, 
#nullable restore
#line 64 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                      ()=>ticket.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.AddMarkupContent(33, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "assign");
            __builder.OpenElement(37, "select");
            __builder.AddAttribute(38, "class", "custom-select");
            __builder.AddAttribute(39, "title", "Select Project");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                              ProjectID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProjectID = __value, ProjectID));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "Select");
            __builder.AddAttribute(44, "selected");
            __builder.AddAttribute(45, "disabled", "disabled");
            __builder.AddContent(46, "(select project)");
            __builder.CloseElement();
#nullable restore
#line 78 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
             foreach (var project in projects)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", 
#nullable restore
#line 81 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                project.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, 
#nullable restore
#line 81 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                             project.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 82 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n      \r\n        ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
                                                  assignTickets

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Assign");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "A:\Tutorial07\Tutorial07\Client\Pages\Edits\EditTicket.razor"
           
        public Guid ProjectID { get; set; }


        [Parameter]
        public Guid TicketID { get; set; }


        private Ticket ticket { get; set; } = new Ticket();

        private List<Project>
            projects = new List<Project>
                ();
        private AssignTicket assignTicket { get; set; } = new AssignTicket();


        protected override async Task OnInitializedAsync()
        {
            try
            {
                ticket = await httpClient.GetFromJsonAsync<Ticket>
                               ($"api/Ticket/{TicketID}");
                projects = await httpClient.GetFromJsonAsync<List<Project>>($"api/Project/");

            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            catch (Exception e)
            {

            }
        }

        private async void HandleValidSubmit()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"/api/Ticket/{ticket.Id}", ticket);
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
        private async void assignTickets()
        {
            assignTicket.TicketID = TicketID;
            assignTicket.ProjectID = ProjectID;

            try
            {
                var response = await httpClient.PostAsJsonAsync($"/api/AssignTicket", assignTicket);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var aT = JsonConvert.DeserializeObject<AssignTicket>(content);
                Navigation.NavigateTo("/Views/viewProjects");


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
namespace __Blazor.Tutorial07.Client.Pages.Edits.EditTicket
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591