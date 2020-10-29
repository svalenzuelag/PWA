namespace RecipeApp.Data
{
    public class Recipe
    {
        public string Id { get; set; } // string because they are strings in the source data

        public string Name { get; set; }

        public int Servings { get; set; }

        public string Instructions { get; set; }

        public string[] Ingredients { get; set; }

        public string[] Tags { get; set; }
    }
}
