#pragma checksum "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "006b0ea9ebaca68d73a0a318502afaf95b423043"
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
#line 3 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
using ChangeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
using ChangeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addstake")]
    public partial class AddStake : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "type", "submit");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                                        ShowModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Add Stake ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 10 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
 if(showModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal");
            __builder.AddAttribute(9, "tabindex", "-1");
            __builder.AddAttribute(10, "role", "dialog");
            __builder.AddAttribute(11, "style", "display:block");
            __builder.AddAttribute(12, "id", "taskModal");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-dialog shadow-lg bg-white rounded");
            __builder.AddAttribute(16, "role", "document");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "modal-content");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "modal-header");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddMarkupContent(24, "<h5 class=\"modal-title\">Add Stake</h5>\r\n                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "close");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                                                  Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "aria-label", "Close");
            __builder.AddContent(30, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal-body");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(36);
            __builder.AddAttribute(37, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                     stake

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                                           AddaStake

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(41);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(43);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row");
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.AddMarkupContent(48, "<label class=\"col-8 col-form-label\">Description:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                                    stake.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stake.Description = __value, stake.Description))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => stake.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddMarkupContent(57, "\r\n                            ");
                __builder2.AddMarkupContent(58, "<label class=\"col-8 col-form-label\">Question:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(59);
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                                        stake.Question

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stake.Question = __value, stake.Question))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => stake.Question));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group row");
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __builder2.AddMarkupContent(68, "<label class=\"col-8 col-form-label\">Examples:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(69);
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                                    stake.Examples

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stake.Examples = __value, stake.Examples))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => stake.Examples));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group row");
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.AddMarkupContent(78, "<label class=\"col-8 col-form-label\">Signers:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
                                                    stake.Signers

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stake.Signers = __value, stake.Signers))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => stake.Signers));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.AddMarkupContent(85, "<div class=\"modal-footer\">\r\n                            <button type=\"submit\" class=\"btn btn-primary\">Add Stake</button>\r\n                        </div>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    <div class=\"modal-backdrop fade show\"></div>    \r\n");
#nullable restore
#line 48 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\plucas\Git\ChangeManagement\Pages\AddStake.razor"
      
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
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StakesService stakeService { get; set; }
    }
}
#pragma warning restore 1591
