#pragma checksum "C:\Users\plucas\ChangeManagement\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e447f18874c9bc9c71ee58417bf9f3aa274ba7a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
                                          Test1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Test");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "  \r\n\r\n");
#nullable restore
#line 10 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
 if(isTest)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "     ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal");
            __builder.AddAttribute(18, "tabindex", "-1");
            __builder.AddAttribute(19, "style", "display:block");
            __builder.AddAttribute(20, "role", "dialog");
            __builder.AddMarkupContent(21, " \r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal-dialog");
            __builder.AddMarkupContent(24, " \r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-content");
            __builder.AddMarkupContent(27, " \r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-header");
            __builder.AddMarkupContent(30, " \r\n                        ");
            __builder.OpenElement(31, "h3");
            __builder.AddAttribute(32, "class", "modal-title");
            __builder.AddContent(33, 
#nullable restore
#line 16 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
                                                 modalTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "  \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
                                                                  IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
                                                                  Test2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Test");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, " \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 25 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\plucas\ChangeManagement\Pages\Counter.razor"
       
    int currentCount = 0;
    string modalTitle;
    Boolean isTest = false;

    void IncrementCount()
    {
        if(!isTest)
        { 
        currentCount++;
        }
    }
    void Test1()
    {
        this.modalTitle = "This is a Test Modal, Count = " + currentCount;
        this.isTest = true;
    }
    void Test2()
    {
        this.isTest = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
