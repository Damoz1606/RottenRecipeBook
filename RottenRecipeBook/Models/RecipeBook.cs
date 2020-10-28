using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RottenRecipeBook.Models
{
    [Table("ReceiptBook")]
    public class RecipeBook
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string RecipeTitle { get; set; }
        public int Time { get; set; }
        //public RecipeType FoodType { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Ingredient> IngredientList { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<RecipeProcess> ProcessList { get; set; }
        public RecipeBook()
        {
            IngredientList = new List<Ingredient>();
            ProcessList = new List<RecipeProcess>();
        }
    }

    public enum RecipeType
    {
        DESSERT, SOUP, MAIN_COURSE, DRINK
    }
}
