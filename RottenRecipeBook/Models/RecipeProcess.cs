using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RottenRecipeBook.Models
{
    [Table("Process")]
    public class RecipeProcess
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(RecipeBook))]
        public int RecieptID { get; set; }
        public int step;
        private string process_string;
        public string ProcessString
        {
            get => process_string;
            set => process_string = value;
        }
        public int Step
        {
            get => step;
            set => step = value;
        }
        public string To_String
        {
            get
            {
                return Step + "-. " + ProcessString;
            }
        }
    }
}
