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
#line 3 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\RecordPath.razor"
using Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\RecordPath.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\RecordPath.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RecordPath")]
    public partial class RecordPath : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "c:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\RecordPath.razor"
       
    private MarkupString PathLines = new MarkupString();
    private MarkupString PathPoints = new MarkupString();
    private MarkupString EditPoints = new MarkupString();

    int Distance = 60;
    string X = "";
    string Y = "";
    string error = "";
    string Message = "";

    WowPoint editPoint = new WowPoint(0, 0);

    public string DisplayBadge(WowPoint point)
    {
        if (this.editPoint == point)
        {
            return "badge-danger";
        }

        return "badge-info";
    }

    protected override void OnInitialized()
    {

        ((Core.AddonReader)addonReader).AddonDataChanged += (o, e) =>
        {
            base.InvokeAsync(() =>
            {
                try
                {
                    AddonDataChanged();
                    StateHasChanged();
                }
                catch { }
            });
        };
    }

    private void UpdateRoute()
    {
        if (botController.RouteInfo != null)
        {
            error = "";
            botController.RouteInfo.SetMargin(20);
            botController.RouteInfo.SetCanvasSize(600);

            if (botController.RouteInfo.PathPoints.Count > 0)
            {
                this.PathLines = new MarkupString(botController.RouteInfo.RenderPathLines(botController.RouteInfo.PathPoints));
                this.PathPoints = new MarkupString(botController.RouteInfo.RenderPathPoints(botController.RouteInfo.PathPoints.Where(p => p != this.editPoint).ToList()));
                this.EditPoints = new MarkupString(botController.RouteInfo.RenderPathPoints(new List<WowPoint> { this.editPoint }));
            }
        }
    }

    protected override async System.Threading.Tasks.Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeAsync<string>("draw");
        }
    }

    private void AddonDataChanged()
    {
        if (!recording) { return; }

        var location = new WowPoint(addonReader.PlayerReader.XCoord, addonReader.PlayerReader.YCoord);

        if (botController.RouteInfo != null)
        {
            if (botController.RouteInfo.PathPoints.Count == 0 || DistanceTo(location, botController.RouteInfo.PathPoints.Last()) > Distance & location.X != 0)
            {
                botController.RouteInfo.PathPoints.Add(location);
                UpdateRoute();
            }
        }
    }

    private double DistanceTo(WowPoint l1, WowPoint l2)
    {
        var x = l1.X - l2.X;
        var y = l1.Y - l2.Y;
        x = x * 100;
        y = y * 100;
        return Math.Sqrt((x * x) + (y * y));
    }

    private bool recording = false;
    private bool editing = false;

    private void Record()
    {
        recording = true;
        editing = false;
        if (botController.RouteInfo != null)
        {
            botController.RouteInfo.PathPoints.Clear();
        }
        Message = "Recording...";
    }

    private void Edit()
    {
        recording = false;
        Message = "Editing...";
        UpdateRoute();
        editing = true;
    }

    private void Clear()
    {
        recording = false;
        if (botController.RouteInfo != null)
        {
            botController.RouteInfo.PathPoints.Clear();
        }
        Message = "Cleared...";
    }

    private void Save()
    {
        if (botController.RouteInfo != null)
        {
            var filename = $"__Path_{ DateTime.Now.ToString("yyyyMMddHHmmss")}.json";
            File.WriteAllText(Path.Join(botController.DataConfig.Path, filename), JsonConvert.SerializeObject(botController.RouteInfo.PathPoints));
            Message = $"Saved to: {filename}";
            recording = false;
        }
    }

    private void EditPoint(WowPoint point)
    {
        this.editPoint = point;
        this.X = point.X.ToString("0.00");
        this.Y = point.Y.ToString("0.00");

        UpdateRoute();

        try
        {
            AddonDataChanged();
            StateHasChanged();
        }
        catch { }
    }

    private void Update()
    {
        try
        {
            editPoint.X = double.Parse(this.X);
            editPoint.Y = double.Parse(this.Y);
            UpdateRoute();
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

    private void Remove()
    {
        if (botController.RouteInfo != null)
        {
            botController.RouteInfo.PathPoints.Remove(editPoint);
            this.editPoint = new WowPoint(0, 0);
            UpdateRoute();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IBotController botController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Core.IAddonReader addonReader { get; set; }
    }
}
#pragma warning restore 1591
