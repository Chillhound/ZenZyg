#pragma checksum "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13996693ced2bda9e6fbff050becd27ef8b7ad6c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZenzygBDSA_Projekt.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using ZenzygBDSA_Projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\_Imports.razor"
using ZenzygBDSA_Projekt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\Shared\RedirectToLogin.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "c:\Users\mikke\OneDrive\Dokumenter\3. semester\BDSA projekt\ZenzygBDSA_Projekt\ZenzygBDSA_Projekt\Shared\RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
