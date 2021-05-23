// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using Core.Session;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\_Imports.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
using Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
using SharedLib;

#line default
#line hidden
#nullable disable
    public partial class ClassConfigurationComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
       

    private ClassConfiguration? classConfig;

    protected override void OnInitialized()
    {
        if (DataFrameConfiguration.Exists())
        {
            RefreshData();

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

    public void OnGet()
    {
        RefreshData();
    }

    private void OnProfileLoaded(object? sender, EventArgs e)
    {
        RefreshData();
    }

    private void RefreshData()
    {
        classConfig = botController.ClassConfig;
    }

    private void Update()
    {
        if(classConfig != null)
            botController.OverrideClassConfig(classConfig);
    }

    private bool CBool(object? o)
    {
        bool? b = (bool?)o;
        return b.HasValue && b.Value;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IAddonReader addonReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IBotController botController { get; set; }
    }
}
#pragma warning restore 1591
