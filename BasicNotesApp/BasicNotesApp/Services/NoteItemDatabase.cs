using BasicNotesApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNotesApp.Services
{
    public class NoteItemDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public NoteItemDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(NoteItem).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(NoteItem)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<NoteItem>> GetItemsAsync()
        {
            return Database.Table<NoteItem>().ToListAsync();
        }

        public Task<List<NoteItem>> GetItemsNotDoneAsync()
        {
            // SQL queries are also possible
            return Database.QueryAsync<NoteItem>("SELECT * FROM [NoteItem] WHERE [Done] = 0");
        }

        public Task<NoteItem> GetItemAsync(int id)
        {
            return Database.Table<NoteItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(NoteItem item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(NoteItem item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
