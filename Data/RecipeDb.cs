using Blazor.IndexedDB.Framework;
using Microsoft.JSInterop;

namespace RecipeApp.Data
{
    public class RecipeDb : IndexedDb
    {
        public RecipeDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }
        public IndexedSet<Recipe> Recipes { get; set; }
    }
}
