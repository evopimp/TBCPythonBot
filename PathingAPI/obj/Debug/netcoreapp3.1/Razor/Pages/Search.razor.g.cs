#pragma checksum "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867bef1f5886d1f333d151434b394dc8f5c39c74"
// <auto-generated/>
#pragma warning disable 1591
namespace PathingAPI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using PathingAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\_Imports.razor"
using PathingAPI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
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
            __builder.OpenComponent<PathingAPI.Pages.Watch>(0);
            __builder.AddAttribute(1, "PathColour", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
                    pathColour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
                                       name

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "span");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<PathingAPI.Pages.SearchParameters>(6);
            __builder.AddAttribute(7, "OnSearch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<PathingAPI.SearchParam>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<PathingAPI.SearchParam>(this, 
#nullable restore
#line 11 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
                                OnSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "IsDisabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
                                                       IsDisabled

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\PathingAPI\Pages\Search.razor"
       
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
