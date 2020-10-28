using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RottenRecipeBook.Models
{
    [Table("Ingredient")]
    public class Ingredient
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(RecipeBook))]
        public int RecieptID { get; set; }
        public string IngredientString { get; set; }
        public int IngredientNum { get; set; }
    }
}
