#pragma checksum "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716c2ae402c56be98d4e934851e822a3b87e4b0d"
// <auto-generated/>
#pragma warning disable 1591
namespace ChangeManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using ChangeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using ChangeManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\plucas\Git\ChangeManagement\_Imports.razor"
using System.DirectoryServices.ActiveDirectory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
using ChangeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
using ChangeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stakes")]
    public partial class Stakes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
 if (stakes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 10 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<thead class=\"sticky-top\">\n            <tr>\n                <th>Stake</th>\n                <th>Question</th>\n                <th>Examples</th>\n                <th>Signers</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddAttribute(8, "class", "sticky-third");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 24 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
             foreach (var stake in stakes)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
                         stake.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
                         stake.Question

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
                         stake.Examples

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 30 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
                         stake.Signers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
#nullable restore
#line 32 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#nullable restore
#line 35 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\plucas\Git\ChangeManagement\Pages\Stakes.razor"
       
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
