using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DilisenseApi.Models {
    public class Entity : ResponseItem {
        [JsonPropertyName("company_number")]
        public List<string>? CompanyNumber { get; set; }
        [JsonPropertyName("jurisdiction")]
        public List<string>? Jurisdictions { get; set; }
    }
}
