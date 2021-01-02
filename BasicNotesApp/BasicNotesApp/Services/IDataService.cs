using BasicNotesApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasicNotesApp.Services
{
    public interface IDataService
    {
        //Task<IEnumerable<NoteItem>> GetNotesAsync();

        Task<IEnumerable<NoteItem>> GetItemsAsync();

    }
}
