#pragma checksum "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618532e0806e2382891559bfeea45fe25fb83736"
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
#line 1 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
using Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
using SharedLib;

#line default
#line hidden
#nullable disable
    public partial class ClassConfigurationComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
 if (classConfig != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\">\r\n            Class Configuration\r\n        </div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddAttribute(7, "style", "padding-bottom: 0");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-bordered");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                 foreach (var property in classConfig.GetType().GetProperties())
                {
                    if (property.Name.Contains("ClassName") ||
                        property.Name.Contains("PathFilename") ||
                        property.Name.Contains("SpiritPathFilename") ||
                        property.Name.Contains("OverridePathFilename")
                        )
                        continue;

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 22 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                     switch (property.PropertyType.FullName)
                    {
                        case "System.String":

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 25 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                  property.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 27 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                               property.GetValue(classConfig)?.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                                  c => { property.SetValue(classConfig, c.Value); Update(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 30 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                            break;

                        case "System.Int32":

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 33 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                  property.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 35 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                               property.GetValue(classConfig)?.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                                  c => { int n = System.Convert.ToInt32(c.Value); property.SetValue(classConfig, n); Update(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 38 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                            break;
                        case "System.Boolean":

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                            ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 40 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                  property.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\r\n                                ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "checkbox");
            __builder.AddAttribute(45, "checked", 
#nullable restore
#line 42 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                                                  CBool(property.GetValue(classConfig))

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                                                  c => { property.SetValue(classConfig, c.Value); Update(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 45 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                            break;
                        default: /*Unsuported/Not implemented editing*/

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "                            \r\n");
#nullable restore
#line 48 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                            break;
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 51 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 55 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\ClassConfigurationComponent.razor"
       

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
