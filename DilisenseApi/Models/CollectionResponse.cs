using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DilisenseApi.Models {
    public class CollectionResponse<T> where T : class {
        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }
        [JsonPropertyName("total_hits")]
        public int? TotalHits { get; set; }
        [JsonPropertyName("found_records")]
        public List<T>? FoundRecords { get; set; }
    }
}
