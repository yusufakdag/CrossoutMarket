﻿using Crossout.Model.Recipes;
using Newtonsoft.Json;

namespace Crossout.AspWeb.Models.Recipes
{
    public class IngredientUsageItem
    {
        public int RecipeId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
    }
}
