#pragma checksum "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2bf7fdb66c4cf3ad6467e89ea83a85a1b4557ec"
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
#line 1 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using ChangeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using ChangeManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Peyton\BlazorProjects\ChangeManagement\_Imports.razor"
using System.DirectoryServices.ActiveDirectory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor"
using ChangeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor"
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
#line 45 "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\Stakes.razor"
       
    IList<Stake> stakes = new List<Stake>();

    protected override async Task OnInitializedAsync()
    {
        stakes = await StakeService.GetStakesAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StakesService StakeService { get; set; }
    }
}
#pragma warning restore 1591
