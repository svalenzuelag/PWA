#pragma checksum "B:\josue\Documents\Documentos\PWA\Pages\RecipeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11c9dc5f0a28ace973cb1b278e386f09c06f133a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using Blazor.IndexedDB.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "B:\josue\Documents\Documentos\PWA\_Imports.razor"
using PWA.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipes/{RecipeId}")]
    public partial class RecipeDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "B:\josue\Documents\Documentos\PWA\Pages\RecipeDetails.razor"
       
    [Parameter] string RecipeId { get; set; }

    Recipe recipe;

    protected override async Task OnInitAsync()
    {
        recipe = await Repository.GetRecipeByIdAsync(RecipeId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecipeRepository Repository { get; set; }
    }
}
#pragma warning restore 1591