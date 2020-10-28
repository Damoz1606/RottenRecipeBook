using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using RottenRecipeBook.Services;
using RottenRecipeBook.Views;

namespace RottenRecipeBook
{
    public partial class App : Application
    {
        private static RecipeDataStore database;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<RecipeDataStore>();
            MainPage = new AppShell();
        }

        public static RecipeDataStore DataBase
        {
            get
            {
                if(database == null)
                {
                    database = new RecipeDataStore(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Recipes.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
