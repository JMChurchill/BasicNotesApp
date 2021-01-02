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

        private void OnSaveBtnClicked(object sender, EventArgs e)
        {

        }

        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {

        }
    }
}