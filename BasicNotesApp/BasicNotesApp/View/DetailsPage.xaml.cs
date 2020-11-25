using BasicNotesApp.Model;
using BasicNotesApp.ViewModel;
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
    public partial class DetailsPage : ContentView
    {
        public DetailsPage()
        {
            InitializeComponent();
        }

        public DetailsPage(Note note)
        {
            InitializeComponent();
            BindingContext = new NoteDetailsViewModel(note);
        }
    }
}