#pragma checksum "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b3d01c9cf88262149420697ea2503859de55f5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/History")]
    public partial class History : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
  
  var pageSize = new List<int> { 15, 50, 100 };

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\r\n\r\n");
#nullable restore
#line 10 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
 if (PreviousBotSessions.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorTable.Table<GrindSession>>(1);
            __builder.AddAttribute(2, "class", "table table-dark table-striped table-hover");
            __builder.AddAttribute(3, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<GrindSession>>(
#nullable restore
#line 12 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                          PreviousBotSessions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                         15

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ColumnReorder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ShowSearchBar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(9);
                __builder2.AddAttribute(10, "Title", "Date");
                __builder2.AddAttribute(11, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                         x => x.SessionStart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Width", "10%");
                __builder2.AddAttribute(15, "DefaultSortColumn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "DefaultSortDescending", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 13 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(18);
                __builder2.AddAttribute(19, "Title", "Path");
                __builder2.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 14 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                         x => x.PathName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Width", "15%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(25);
                __builder2.AddAttribute(26, "Title", "Class");
                __builder2.AddAttribute(27, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 15 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                          x => x.PlayerClass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Width", "5%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(32);
                __builder2.AddAttribute(33, "Title", "Duration");
                __builder2.AddAttribute(34, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 16 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                             x => x.TotalTimeInMinutes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Width", "5%");
                __builder2.AddAttribute(38, "Template", (Microsoft.AspNetCore.Components.RenderFragment<GrindSession>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n");
#nullable restore
#line 18 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
        
        var theSession = (context as GrindSession);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(40, "        ");
                    __builder3.OpenElement(41, "span");
                    __builder3.AddContent(42, 
#nullable restore
#line 20 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
               theSession?.TotalTimeInMinutes

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(43, " minutes");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n");
                    __builder3.AddContent(45, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(47);
                __builder2.AddAttribute(48, "Title", "Level");
                __builder2.AddAttribute(49, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 24 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                          x => x.LevelFrom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Width", "5%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(54);
                __builder2.AddAttribute(55, "Title", "Exp");
                __builder2.AddAttribute(56, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 25 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                        x => x.ExpGetInBotSession

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "Width", "5%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(61);
                __builder2.AddAttribute(62, "Title", "Exp/Hour");
                __builder2.AddAttribute(63, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 26 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                             x => x.ExperiencePerHour

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Width", "5%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(68);
                __builder2.AddAttribute(69, "Title", "Mobs");
                __builder2.AddAttribute(70, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 27 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                         x => x.MobsKilled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "Width", "5%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(75);
                __builder2.AddAttribute(76, "Title", "Mobs/Min");
                __builder2.AddAttribute(77, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 28 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                             x => x.MobsPerMinute

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "Width", "5%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Column<GrindSession>>(82);
                __builder2.AddAttribute(83, "Title", "Death");
                __builder2.AddAttribute(84, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<GrindSession, System.Object>>>(
#nullable restore
#line 29 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                          x => x.Death

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "Width", "5%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n  ");
                __builder2.OpenComponent<BlazorTable.Pager>(89);
                __builder2.AddAttribute(90, "ShowPageNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ShowTotalCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Int32>>(
#nullable restore
#line 30 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                 pageSize

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "ShowPageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, " \r\n");
#nullable restore
#line 32 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "  ");
            __builder.AddMarkupContent(97, "<div>No previous bot sessions</div>\r\n");
#nullable restore
#line 35 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\hopki\OneDrive\Documents\Myaddon\Wickedaddon\WowClassicGrindBot\BlazorServer\Pages\History.razor"
       
    [Parameter]
    public List<GrindSession> PreviousBotSessions { get; set; } = new List<GrindSession>();

    protected override void OnInitialized()
    {
        PreviousBotSessions = Session.Load();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGrindSession Session { get; set; }
    }
}
#pragma warning restore 1591
