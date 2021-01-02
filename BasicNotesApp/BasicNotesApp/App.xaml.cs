using System;
using Xamarin.Forms;
using BasicNotesApp.View;
using Xamarin.Forms.Xaml;
using BasicNotesApp.Services;

namespace BasicNotesApp
{
    public partial class App : Application
    {
        static NoteItemDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = (Color)Resources["Primary"],
                BarTextColor = Color.White
            };

            //MainPage = new MainPage();
        }

        public static NoteItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteItemDatabase();
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
