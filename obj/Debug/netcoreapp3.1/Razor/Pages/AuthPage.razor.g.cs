#pragma checksum "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a612d9cce3764f502263dd65728d487d20d2715"
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
#line 1 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using ChangeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using ChangeManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using System.DirectoryServices.ActiveDirectory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authpage")]
    public partial class AuthPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ClaimsPrincipal Data</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
                  GetClaimsPrincipalData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Get ClaimsPrincipal Data");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
    _authMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
 if (_claims.Count() > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "ul");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 15 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
         foreach (var claim in _claims)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "li");
            __builder.AddContent(13, 
#nullable restore
#line 17 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
                 claim.Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, ": ");
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
                              claim.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 18 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 20 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "p");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
    _surnameMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AuthPage.razor"
       
    private string _authMessage;
    private string _surnameMessage;
    private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

    private async Task GetClaimsPrincipalData()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            _authMessage = $"{user.Identity.Name} is authenticated.";
            _claims = user.Claims;
            _surnameMessage = 
                $"Surname: {user.FindFirst(c => c.Type == ClaimTypes.Surname)?.Value}";
        }
        else
        {
            _authMessage = "The user is NOT authenticated.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
