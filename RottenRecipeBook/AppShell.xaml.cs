using System;
using System.Collections.Generic;

using Xamarin.Forms;

using RottenRecipeBook.Views;

namespace RottenRecipeBook
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecipesPage), typeof(RecipesPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(RecipeDetailPage), typeof(RecipeDetailPage));
            Routing.RegisterRoute(nameof(NewRecipePage), typeof(NewRecipePage));
        }

    }
}
