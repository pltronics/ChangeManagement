#pragma checksum "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1619d4707be1ae0689e7971b85f991bce22d9e55"
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
#line 1 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using ChangeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using ChangeManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\plucas\ChangeManagement\_Imports.razor"
using System.DirectoryServices.ActiveDirectory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cancel")]
    public partial class Cancel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cancel Validation</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "submit");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
                                                        Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<hr>\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Status: ");
            __builder.AddContent(9, 
#nullable restore
#line 8 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
            status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
#nullable restore
#line 10 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
 if (showModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal");
            __builder.AddAttribute(14, "tabindex", "-1");
            __builder.AddAttribute(15, "role", "dialog");
            __builder.AddAttribute(16, "style", "display:block");
            __builder.AddAttribute(17, "id", "taskModal");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-dialog shadow-lg bg-white rounded");
            __builder.AddAttribute(21, "role", "document");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "modal-content");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\">Login</h5>\r\n                </div>\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-body");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(30);
            __builder.AddAttribute(31, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
                                     user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(37);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.AddMarkupContent(42, "<label class=\"col-3 col-form-label\">Email: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "class", "col-8 form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
                                                                               user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __builder2.AddMarkupContent(53, "<label class=\"col-3 col-form-label\">Password: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "type", "password");
                __builder2.AddAttribute(56, "class", "col-8 form-control");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
                                                                                               user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "modal-footer");
                __builder2.AddMarkupContent(64, "\r\n                            ");
                __builder2.AddMarkupContent(65, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                            ");
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "type", "button");
                __builder2.AddAttribute(68, "class", "btn btn-secondary");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
                                                                                      CancelSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(70, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 39 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\plucas\ChangeManagement\Pages\Cancel.razor"
       

    public class UserLogin
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }

    UserLogin user = new UserLogin();

    bool showModal;
    string status;

    protected override void OnInitialized()
    {
        showModal = false;
        status = "Init";
        // for demo purposes, if you delete user.Email in the login dialog, you'll need to press 'Cancel' 2 times.
        user.Email = "user@example.com";
        user.Password = "12345";
    }

    private void Login()
    {
        status = "Show Login Modal";
        showModal = true;
    }

    private void HandleValidSubmit()
    {
        status = "Valid Submit";
        showModal = false;
    }

    private void CancelSubmit()
    {
        status = "Cancelled"; 
        showModal = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
