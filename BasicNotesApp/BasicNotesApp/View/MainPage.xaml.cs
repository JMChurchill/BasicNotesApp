using BasicNotesApp.Model;
using BasicNotesApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BasicNotesApp
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private async void NewNote(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage 
            { 
                BindingContext = new NoteItem()
            });
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsPage
                {
                    BindingContext = e.SelectedItem as NoteItem
                });
            }
        }
    }
}
