// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Details/detailsProject/{Id:guid}")]
    public partial class ProjectDetails_ : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "A:\Tutorial07\Tutorial07\Client\Pages\Details\ProjectDetails .razor"
       
    [Parameter]
    public Guid Id { get; set; }
    private Project project { get; set; } = new Project();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            project = await httpClient.GetFromJsonAsync<Project>($"api/Project/{Id}");

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
