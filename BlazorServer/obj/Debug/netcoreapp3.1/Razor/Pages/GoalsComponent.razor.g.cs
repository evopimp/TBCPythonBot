#pragma checksum "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ecf10389626f3910989e7b861119a5f6fc8027b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Core.Session;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
using Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
using SharedLib;

#line default
#line hidden
#nullable disable
    public partial class GoalsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "margin-top: 10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        Goals -> ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                  addonReader.PlayerReader.MinRange

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " - ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                                                       addonReader.PlayerReader.MaxRange

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-sm btn-primary float-right");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                                                                     ToggleBot

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "disabled", 
#nullable restore
#line 9 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                                                                                            disableButton ? "disabled" : null

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
             if (!botController.IsBotActive)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.AddMarkupContent(17, "<span>Start Bot</span>\r\n");
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.AddMarkupContent(19, "<span>Stop Bot</span>\r\n");
#nullable restore
#line 17 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 20 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
     if (ShowGoals)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-body");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table table-sm table-striped");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 24 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                 if (botController.GoapAgent != null)
                {
                    foreach (var goal in botController.GoapAgent.AvailableGoals)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                        ");
            __builder.OpenComponent<BlazorServer.Pages.GoapGoalView>(31);
            __builder.AddAttribute(32, "goal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Core.Goals.GoapGoal>(
#nullable restore
#line 28 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                                            goal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "IsSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                                                              (goal == botController.GoapAgent.CurrentGoal)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ShowKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 29 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 33 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\GoalsComponent.razor"
       

    bool disableButton = false;

    [Parameter]
    public bool ShowGoals { get; set; } = true;

    protected override void OnInitialized()
    {
        if (DataFrameConfiguration.Exists())
        {
            ValidateButton();

            botController.ProfileLoaded -= OnProfileLoaded;
            botController.ProfileLoaded += OnProfileLoaded;

            ((Core.AddonReader)addonReader).AddonDataChanged += (o, e) =>
            {
                base.InvokeAsync(() =>
                {
                    try
                    {
                        StateHasChanged();
                    }
                    catch { }
                });
            };
        }
    }

    private void ToggleBot()
    {
        botController.ToggleBotStatus();
    }

    private void OnProfileLoaded(object? sender, EventArgs e)
    {
        ValidateButton();
    }

    private void ValidateButton()
    {
        disableButton = string.IsNullOrEmpty(botController.SelectedClassFilename);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IAddonReader addonReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IBotController botController { get; set; }
    }
}
#pragma warning restore 1591
