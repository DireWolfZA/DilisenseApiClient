using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DilisenseApi.Models {
    public class Individual {
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
        [JsonPropertyName("gender")]
        public Gender? Gender { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("tl_name")]
        public string? TransliteratedName { get; set; }
        [JsonPropertyName("alias_names")]
        public List<string>? AliasNames { get; set; }
        [JsonPropertyName("last_names")]
        public List<string>? LastNames { get; set; }
        [JsonPropertyName("given_names")]
        public List<string>? GivenNames { get; set; }
        [JsonPropertyName("alias_given_names")]
        public List<string>? AliasGivenNames { get; set; }
        [JsonPropertyName("name_remarks")]
        public List<string>? NameRemarks { get; set; }
        [JsonPropertyName("spouse")]
        public List<string>? SpouseNames { get; set; }
        [JsonPropertyName("parents")]
        public List<string>? ParentNames { get; set; }
        [JsonPropertyName("children")]
        public List<string>? ChildrenNames { get; set; }
        [JsonPropertyName("siblings")]
        public List<string>? SiblingNames { get; set; }
        [JsonPropertyName("date_of_birth")]
        public List<string>? DateOfBirth { get; set; }
        [JsonPropertyName("date_of_birth_remarks")]
        public List<string>? DateOfBirthRemarks { get; set; }
        [JsonPropertyName("place_of_birth")]
        public List<string>? PlaceOfBirth { get; set; }
        [JsonPropertyName("place_of_birth_remarks")]
        public List<string>? PlaceOfBirthRemarks { get; set; }
        [JsonPropertyName("address")]
        public List<string>? Address { get; set; }
        [JsonPropertyName("address_remarks")]
        public List<string>? AddressRemarks { get; set; }
        [JsonPropertyName("citizenship")]
        public List<string>? Citizenships { get; set; }
        [JsonPropertyName("citizenship_remarks")]
        public List<string>? CitizenshipRemarks { get; set; }
        [JsonPropertyName("sanction_details")]
        public List<string>? SanctionDetails { get; set; }
        [JsonPropertyName("description")]
        public List<string>? Descriptions { get; set; }
        [JsonPropertyName("occupations")]
        public List<string>? Occupations { get; set; }
        [JsonPropertyName("positions")]
        public List<string>? Positions { get; set; }
        [JsonPropertyName("political_parties")]
        public List<string>? PoliticalParties { get; set; }
        [JsonPropertyName("links")]
        public List<string>? Links { get; set; }
        [JsonPropertyName("titles")]
        public List<string>? Titles { get; set; }
        [JsonPropertyName("functions")]
        public List<string>? Functions { get; set; }
        [JsonPropertyName("other_information")]
        public List<string>? OtherInformation { get; set; }
        [JsonPropertyName("source_country")]
        public List<string>? SourceCountry { get; set; }
    }
}
