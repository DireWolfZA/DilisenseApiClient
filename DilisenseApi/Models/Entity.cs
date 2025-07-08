using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DilisenseApi.Models {
    public class Entity {
        [JsonPropertyName("source_type")]
        public SourceType? SourceType { get; set; }
        [JsonPropertyName("pep_type")]
        public PEPType? PEPType { get; set; }
        [JsonPropertyName("source_id")]
        public string? SourceID { get; set; }
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        [JsonPropertyName("entity_type")]
        public EntityType? EntityType { get; set; }
        [JsonPropertyName("list_date")]
        public long? ListDate { get; set; }
        [JsonPropertyName("company_number")]
        public List<string>? CompanyNumber { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("tl_name")]
        public string? TransliteratedName { get; set; }
        [JsonPropertyName("alias_names")]
        public List<string>? AliasNames { get; set; }
        [JsonPropertyName("name_remarks")]
        public List<string>? NameRemarks { get; set; }
        [JsonPropertyName("jurisdiction")]
        public List<string>? Jurisdictions { get; set; }
        [JsonPropertyName("address")]
        public List<string>? Address { get; set; }
        [JsonPropertyName("address_remarks")]
        public List<string>? AddressRemarks { get; set; }
        [JsonPropertyName("sanction_details")]
        public List<string>? SanctionDetails { get; set; }
        [JsonPropertyName("links")]
        public List<string>? Links { get; set; }
        [JsonPropertyName("other_information")]
        public List<string>? OtherInformation { get; set; }
        [JsonPropertyName("source_country")]
        public List<string>? SourceCountry { get; set; }
    }
}
