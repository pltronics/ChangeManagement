#pragma checksum "c:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1e3a980cfbc4cad74cfd9930e8be6337ac7429e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ChangeManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using ChangeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using ChangeManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor"
using ChangeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor"
using ChangeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stakes")]
    public class Stakes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "c:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor"
       
    IList<Stake> stakes = new List<Stake>();

    protected override async Task OnInitializedAsync()
    {
        stakes = await ChangeService.GetStakesAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChangeManagementService ChangeService { get; set; }
    }
}
#pragma warning restore 1591
