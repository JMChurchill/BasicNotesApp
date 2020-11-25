using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicNotesApp.Model
{
    public partial class Note
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Note")]
        public string NoteNote { get; set; }
    }

    public partial class Note
    {
        public static Note[] FromJson(string json) => JsonConvert.DeserializeObject<Note[]>(json, BasicNotesApp.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Note[] self) => JsonConvert.SerializeObject(self, BasicNotesApp.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
