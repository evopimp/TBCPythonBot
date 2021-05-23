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
#line 1 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ProfileSelectorComponent.razor"
using Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ProfileSelectorComponent.razor"
using SharedLib;

#line default
#line hidden
#nullable disable
    public partial class ProfileSelectorComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ProfileSelectorComponent.razor"
       

    [Parameter]
    public bool Hide { get; set; } = false;

    List<string> files = new List<string> { string.Empty };

    string selectedProfile = String.Empty;
    bool disableButton = true;

    protected override void OnInitialized()
    {
        if (DataFrameConfiguration.Exists())
        {
            RefreshData();

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

    private void LoadClassProfile()
    {
        if(!string.IsNullOrEmpty(selectedProfile)) {
            botController.LoadClassProfile(selectedProfile);
        }
    }

    private void OnListBoxChanged(ChangeEventArgs changeEventArgs)
    {
        selectedProfile = (string)changeEventArgs.Value;
        disableButton = string.IsNullOrEmpty(selectedProfile);
    }

    private void RefreshData()
    {
        files = botController.ClassFileList();
        selectedProfile = botController.SelectedClassFilename;
        disableButton = string.IsNullOrEmpty(selectedProfile);
    }

    private async Task SyncActionBar()
    {
        if (botController.ActionBarPopulator == null) return;
        await botController.ActionBarPopulator.Execute();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IAddonReader addonReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IBotController botController { get; set; }
    }
}
#pragma warning restore 1591