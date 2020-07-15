#pragma checksum "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b123f2a17abbda115a55aa4acc782a7fd5d9c5bb"
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
#line 3 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
using ChangeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
using ChangeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddMarkupContent(1, "Changes \n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
                                          ClearChanges

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Clear List");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n");
            __builder.OpenComponent<ChangeManagement.Pages.AddChange>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "id", "table-wrapper");
            __builder.AddMarkupContent(12, "\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "table-scroll");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 17 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
 if (changes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.AddMarkupContent(17, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 20 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table");
            __builder.AddMarkupContent(21, "\n        ");
            __builder.AddMarkupContent(22, @"<thead class=""sticky-top"">
            <tr>
                
                <th>Title</th>
                <th>Description</th>
                <th>Owner</th>
                <th>Created On</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(23, "tbody");
            __builder.AddAttribute(24, "class", "sticky-third");
            __builder.AddMarkupContent(25, "\n");
#nullable restore
#line 37 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
             foreach (var change in changes)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\n                    \n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 41 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
                         change.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 42 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
                         change.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 43 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
                         change.Owner

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 44 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
                         change.CreatedOn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
                                                                  (() => AddNotes(change.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Add Notes");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.AddMarkupContent(47, "<td><button class=\"btn btn-primary\">Sign Off</button></td>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
#nullable restore
#line 48 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n");
#nullable restore
#line 51 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\plucas\Git\ChangeManagement\Pages\FetchData.razor"
       
    IList<Change> changes = new List<Change>();
    protected override async Task OnInitializedAsync()
    {
        changes = await ChangeService.GetChangesAsync();
    }
    protected async Task ClearChanges()
    {
        await ChangeService.DeleteChangesAsync();
        changes = await ChangeService.GetChangesAsync();
    }
    protected void AddNotes(int id)
    {
        Console.WriteLine("AddNote " + id + " Pressed");
        ;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChangeManagementService ChangeService { get; set; }
    }
}
#pragma warning restore 1591
