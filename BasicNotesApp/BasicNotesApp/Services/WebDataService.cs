using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BasicNotesApp.Model;
using BasicNotesApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebDataService))]
namespace BasicNotesApp.Services
{
    public class WebDataService //: IDataService
    {
        //HttpClient httpClient;
        //HttpClient Client => httpClient ?? (httpClient = new HttpClient());
        //public async Task<IEnumerable<NoteItem>> GetNotesAsync()
        //{
        //    var json = await Client.GetStringAsync("https://raw.githubusercontent.com/JMChurchill/BasicNotesApp/master/data.json");
        //    var all = NoteItem.FromJson(json);
        //    return all;
        //}
    }
}
