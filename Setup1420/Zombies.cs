using System.Text.Json.Serialization;

namespace program
{
    [Serializable]
    class ZombieSurvivalJournal
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("entries")]
        public List<JournalEntry> Entries { get; set; }


    }


    public class JournalEntry
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}