using BasicNotesApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace BasicNotesApp.ViewModel
{
    class NotesViewModel : BaseViewModel
    {
        public Command GetNotesCommand { get; }

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public Command RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;

                    //await RefreshData(); 
                    await GetNotesAsync();


                    IsRefreshing = false;
                });
            }
        }
        public ObservableCollection<Note> Notes { get; }
        public NotesViewModel()
        {
            Notes = new ObservableCollection<Note>();
            Title = "Notes App";
            GetNotesCommand = new Command(async () => await GetNotesAsync());
        }

        async Task GetNotesAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var notes = await DataService.GetNotesAsync();
                Notes.Clear();
                foreach (var note in notes)
                {
                    Notes.Add(note);
                }
                //Title = $"Notes App ({Notes.Count})";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get notes: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");

            }
            finally
            {
                IsBusy = false;
            }
        }


    }
}
