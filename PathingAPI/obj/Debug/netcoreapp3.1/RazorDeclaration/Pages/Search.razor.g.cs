// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PathingAPI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using PathingAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using PathingAPI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
using PathingAPI.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
       
    bool IsDisabled = true;

    PatherPath.Graph.PathGraph.eSearchScoreSpot searchType;
    int pathColour = 1;
    string name;
    SearchParam parameters;

    System.Threading.Thread searchPathThread;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("createScene");

            PatherPath.Graph.PathGraph.SearchEnabled = true;

            pPatherService.Reset();


            //var mapId = 1451;
            //this.parameters = new SearchParam
            //{
            //    From = pPatherService.GetWorldLocation(mapId, 46.8f, 54.2f),
            //    To = pPatherService.GetWorldLocation(mapId, 51.2f, 38.9f)
            //};

            //var mapId = 1428;
            //this.parameters = new SearchParam
            //{
            //    From= pPatherService.GetWorldLocation(mapId, 82.7f, 63.2f),
            //    To= pPatherService.GetWorldLocation(mapId, 64.9f, 27.0f)
            //};

            //DoSearch(PatherPath.Graph.PathGraph.eSearchScoreSpot.OriginalPather, 1, "Test");

            IsDisabled = false;
            await InvokeAsyncBase(() => StateHasChanged());
        }
    }

    public async Task InvokeAsyncBase(Action action)
    {
        await base.InvokeAsync(() =>
        {
            try { action(); } catch { }
        });
    }

    public async Task OnSearch(SearchParam searchParameters)
    {
        if (searchParameters.From == null || searchParameters.To == null)
        {
            return;
        }
        this.parameters = searchParameters;

        await DoSearch(parameters.SearchType, ((int)parameters.SearchType) + 1, parameters.SearchType.ToString());
    }

    private async Task DoSearch(PatherPath.Graph.PathGraph.eSearchScoreSpot searchType, int colour, string name)
    {
        IsDisabled = true;

        this.searchType = searchType;
        this.pathColour = colour;
        this.name = name;

        PatherPath.Graph.PathGraph.SearchEnabled = true;
        PatherPath.Graph.PathGraph.ProgressTimeoutSeconds = 60;
        PatherPath.Graph.PathGraph.TimeoutSeconds = 600;

        await InvokeAsyncBase(() => StateHasChanged());

        searchPathThread = new System.Threading.Thread(new System.Threading.ThreadStart(SearchPathThread));
        searchPathThread.Start();
    }

    public void SearchPathThread()
    {
        try
        {
            InvokeAsyncBase(() => jsRuntime.InvokeVoidAsync("removeMeshes", name)).Wait();
            InvokeAsyncBase(() => jsRuntime.InvokeVoidAsync("removeMeshes", "search")).Wait();


            var from = parameters.From;
            var to = parameters.To;

            pPatherService.SetLocations(from, to);

            var patherPath = pPatherService.DoSearch(searchType);

            InvokeAsyncBase(() => { IsDisabled = false; StateHasChanged(); }).Wait();
        }
        catch (Exception ex)
        {
            InvokeAsyncBase(() => jsRuntime.InvokeVoidAsync("log", ex.Message)).Wait();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PPatherService pPatherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
