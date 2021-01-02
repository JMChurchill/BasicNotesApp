using BasicNotesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicNotesApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }

        private async void OnSaveBtnClicked(object sender, EventArgs e)
        {
            var noteItem = (NoteItem)BindingContext;
            await App.Database.SaveItemAsync(noteItem);
            await Navigation.PopAsync();
        }

        private async void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            var noteItem = (NoteItem)BindingContext;
            await App.Database.DeleteItemAsync(noteItem);
            await Navigation.PopAsync();
        }
    }
}