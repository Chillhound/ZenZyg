// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZenZygClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using ZenZygClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using ZenZygClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/Users/anesskrijelj/GitHub/Personal/ZenZygBackup/ZenZygClient/Pages/Index.razor"
          
        private Shop[] shops;

        protected override async Task OnInitializedAsync()
        {
            shops = await _client.GetFromJsonAsync<Shop[]>("sample-data/shops.json");
        }

        public class Shop
        {
            public string Navn { get; set; }

            public int Distance { get; set; }

            public string Ejer { get; set; }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
#pragma warning restore 1591
