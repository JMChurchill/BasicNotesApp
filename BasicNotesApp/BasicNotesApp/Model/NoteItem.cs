using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using SQLite;


namespace BasicNotesApp.Model
{
    public partial class NoteItem
    {
        
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }


        //[JsonProperty("Title")]
        //public string Title { get; set; }

        //[JsonProperty("Note")]
        //public string NoteNote { get; set; }
    }

    //public partial class NoteItem
    //{
    //    public static NoteItem[] FromJson(string json) => JsonConvert.DeserializeObject<NoteItem[]>(json, BasicNotesApp.Model.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this NoteItem[] self) => JsonConvert.SerializeObject(self, BasicNotesApp.Model.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}
