#pragma checksum "c:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AddNote2 copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f781fca02a388270d36945cf64fa550e3251db"
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
#line 1 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using ChangeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using ChangeManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\plucas\ChangeManagement\ChangeManagement\_Imports.razor"
using System.DirectoryServices.ActiveDirectory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AddNote2 copy.razor"
using ChangeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AddNote2 copy.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addnote")]
    public partial class AddNote2_copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "c:\Users\plucas\ChangeManagement\ChangeManagement\Pages\AddNote2 copy.razor"
      
    bool showModal;
    private void ShowModal()
    {
        showModal = true;
    }

    public void HandleValidSubmit()
    {
        showModal = false;
    }
    private void Cancel()
    {
        showModal = false;
    }
    public class Change
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title {get; set;}
        [Required(ErrorMessage = "Description is required")]
        public string Description {get; set;}
        public string Owner {get; set;}
    }

    Change change = new Change();

    protected override void OnInitialized()
    {
        change.Title = "";
        showModal = false;
    }

    protected async Task AddaChange()
    {
        Console.WriteLine("Button Pressed");
        await ChangeService.AddChangeAsync(change.Title, change.Description, change.Owner);
        showModal = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChangeManagementService ChangeService { get; set; }
    }
}
#pragma warning restore 1591
