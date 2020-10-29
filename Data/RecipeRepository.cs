using Blazor.IndexedDB.Framework;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RecipeApp.Data
{
    public class RecipeRepository   
    {
        private readonly HttpClient httpClient;
        private readonly IIndexedDbFactory dbFactory;
        private readonly Task<RecipeDb> openingDbTask;

        public RecipeRepository(HttpClient httpClient, IIndexedDbFactory dbFactory)
        {
            this.httpClient = httpClient;
            this.dbFactory = dbFactory;
            this.openingDbTask = OpenDbAsync();
        }

        public async Task<IndexedSet<Recipe>> GetAllRecipesAsync()
            => (await openingDbTask).Recipes;

        public async Task<Recipe> GetRecipeByIdAsync(string id)
            => (await openingDbTask).Recipes.FirstOrDefault(r => r.Id == id);

        public async Task<Recipe[]> FindByTag(string searchTerm)
        {
            var db = await openingDbTask;
            return db.Recipes.Where(r =>
                r.Name.Contains(searchTerm) ||
                r.Tags.Any(t => t.Contains(searchTerm))).ToArray();
        }

        private async Task<RecipeDb> OpenDbAsync()
        {
            var db = await dbFactory.Create<RecipeDb>();
            if (!db.Recipes.Any())
            {
                // We haven't got the data yet - fetch it from the server
                var data = await httpClient.GetJsonAsync<Dictionary<string, Recipe>>("sample-data/db_recipes.json");
                foreach (var recipe in data.Values)
                {
                    db.Recipes.Add(recipe);
                }
                await db.SaveChanges();
            }

            return db;
        }
    }
}
