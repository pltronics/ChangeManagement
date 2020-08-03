#pragma checksum "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\AddStake.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f81a27b7e1bc9a1431ea4b15696fd4cba113f4fe"
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
#line 3 "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\AddStake.razor"
using ChangeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\AddStake.razor"
using ChangeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\AddStake.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addstake")]
    public class AddStake : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Peyton\BlazorProjects\ChangeManagement\Pages\AddStake.razor"
      
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
    public class Stake
    {

        [Required(ErrorMessage = "Description is required")]
        public string Description {get; set;}

        [Required(ErrorMessage = "Question is required")]
        public string Question {get; set;}

        public string Examples {get; set;}

        [Required(ErrorMessage = "A signer is needed")]
        public string Signers {get; set;}
    }

    Stake stake = new Stake();

    protected override void OnInitialized()
    {
        stake.Description = "";
        showModal = false;
    }

    protected async Task AddaStake()
    {
        Console.WriteLine("Button Pressed");
        await stakeService.AddStakeAsync(stake.Description, stake.Question, stake.Examples, stake.Signers);
        OnInitialized();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StakesService stakeService { get; set; }
    }
}
#pragma warning restore 1591