#pragma checksum "/Users/laurashapiro/c#/WebApplication1/Pages/Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d79fc293f4c8a9118886a26e326a19d66698e251"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using WebApplication1;
    using WebApplication1.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 11 "/Users/laurashapiro/c#/WebApplication1/Pages/Counter.cshtml"
            
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }
    void DecrementCount()
    {
        currentCount--;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
