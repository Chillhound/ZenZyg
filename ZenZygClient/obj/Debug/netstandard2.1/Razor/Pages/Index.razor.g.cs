#pragma checksum "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b1e19d621612557e6c599856fc9bdd0579e070"
// <auto-generated/>
#pragma warning disable 1591
namespace ZenZygClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using ZenZygClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using ZenZygClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\_Imports.razor"
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
            __builder.AddMarkupContent(0, "<h1>Supermarked</h1>\r\n");
            __builder.AddMarkupContent(1, "<h2> Brah vlekommen til hovedsiden :*</h2>");
#nullable restore
#line 7 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
     if (shops != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
         foreach (var shop in shops)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "shop card-body");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-title");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
                            shop.Navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-text");
            __builder.AddMarkupContent(13, "<a href=\"/order\" class=\"btn btn-link stretched-link\"></a>\r\n                        ");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, 
#nullable restore
#line 19 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
                            shop.Distance

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " km");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
         
     }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<p>Loading.....</p>");
#nullable restore
#line 28 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "    }\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenZygClient\Pages\Index.razor"
          
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
