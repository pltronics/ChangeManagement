#pragma checksum "C:\Users\plucas\Git\ChangeManagement\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7fb928db3ea68f1c4ab0a3ca1fbc7c069a7d73f"
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
#line 2 "C:\Users\plucas\Git\ChangeManagement\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\plucas\Git\ChangeManagement\Pages\Index.razor"
       

    public class UserLogin
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }

    UserLogin user = new UserLogin();

    bool showModal;

    protected override void OnInitialized()
    {
        showModal = false;
        // for demo purposes, if you delete user.Email in the login dialog, you'll need to press 'Cancel' 2 times.
        user.Email = "";
        user.Password = "";
    }

    private void Login()
    {
        showModal = true;
    }

    private void HandleValidSubmit()
    {
        showModal = false;
    }

    private void CancelSubmit()
    {
        showModal = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
