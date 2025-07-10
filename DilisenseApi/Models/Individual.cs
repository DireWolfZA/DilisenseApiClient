using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DilisenseApi.Models {
    public class Individual : ResponseItem {
        [JsonPropertyName("gender")]
        public Gender? Gender { get; set; }
        [JsonPropertyName("last_names")]
        public List<string>? LastNames { get; set; }
        [JsonPropertyName("given_names")]
        public List<string>? GivenNames { get; set; }
        [JsonPropertyName("alias_given_names")]
        public List<string>? AliasGivenNames { get; set; }
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
        [JsonPropertyName("citizenship")]
        public List<string>? Citizenships { get; set; }
        [JsonPropertyName("citizenship_remarks")]
        public List<string>? CitizenshipRemarks { get; set; }
        [JsonPropertyName("description")]
        public List<string>? Descriptions { get; set; }
        [JsonPropertyName("occupations")]
        public List<string>? Occupations { get; set; }
        [JsonPropertyName("positions")]
        public List<string>? Positions { get; set; }
        [JsonPropertyName("political_parties")]
        public List<string>? PoliticalParties { get; set; }
        [JsonPropertyName("titles")]
        public List<string>? Titles { get; set; }
        [JsonPropertyName("functions")]
        public List<string>? Functions { get; set; }
    }
}
