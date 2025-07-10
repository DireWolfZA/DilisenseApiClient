using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DilisenseApi.Models {
    //[JsonPolymorphic(IgnoreUnrecognizedTypeDiscriminators = true, TypeDiscriminatorPropertyName = "entity_type")]
    //[JsonDerivedType(typeof(Individual), typeDiscriminator: "INDIVIDUAL")]
    //[JsonDerivedType(typeof(Entity), typeDiscriminator: "ENTITY")]
    // System.Text.Json deserialization doesn't allow to put the TypeDiscriminator property in the model & use it to identify types - have to do it manually
    public class ResponseItem {
        [JsonPropertyName("entity_type")]
        public EntityType? EntityType { get; set; }

        [JsonPropertyName("source_type")]
        public SourceType? SourceType { get; set; }
        [JsonPropertyName("pep_type")]
        public PEPType? PEPType { get; set; }
        [JsonPropertyName("source_id")]
        public string? SourceID { get; set; }
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        [JsonPropertyName("list_date")]
        public long? ListDate { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("tl_name")]
        public string? TransliteratedName { get; set; }
        [JsonPropertyName("alias_names")]
        public List<string>? AliasNames { get; set; }
        [JsonPropertyName("name_remarks")]
        public List<string>? NameRemarks { get; set; }
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

    internal class CheckNameResponseItem : Individual { // inherit from Individual instead of ResponseItem - then Individual properties don't have to be copied here, just copy Entity properties
        [JsonPropertyName("company_number")]
        public List<string>? CompanyNumber { get; set; }
        [JsonPropertyName("jurisdiction")]
        public List<string>? Jurisdictions { get; set; }

        public ResponseItem ToResponseItem() {
            var item = new ResponseItem();

            if (EntityType == Models.EntityType.Individual)
                item = new Individual() {
                    Gender = Gender,
                    LastNames = LastNames,
                    GivenNames = GivenNames,
                    AliasGivenNames = AliasGivenNames,
                    SpouseNames = SpouseNames,
                    ParentNames = ParentNames,
                    ChildrenNames = ChildrenNames,
                    SiblingNames = SiblingNames,
                    DateOfBirth = DateOfBirth,
                    DateOfBirthRemarks = DateOfBirthRemarks,
                    PlaceOfBirth = PlaceOfBirth,
                    PlaceOfBirthRemarks = PlaceOfBirthRemarks,
                    Citizenships = Citizenships,
                    CitizenshipRemarks = CitizenshipRemarks,
                    Descriptions = Descriptions,
                    Occupations = Occupations,
                    Positions = Positions,
                    PoliticalParties = PoliticalParties,
                    Titles = Titles,
                    Functions = Functions,
                };
            else if (EntityType == Models.EntityType.Entity)
                item = new Entity() {
                    CompanyNumber = CompanyNumber,
                    Jurisdictions = Jurisdictions,
                };

            item.SourceType = SourceType;
            item.PEPType = PEPType;
            item.SourceID = SourceID;
            item.ID = ID;
            item.EntityType = EntityType;
            item.ListDate = ListDate;
            item.Name = Name;
            item.TransliteratedName = TransliteratedName;
            item.AliasNames = AliasNames;
            item.NameRemarks = NameRemarks;
            item.Address = Address;
            item.AddressRemarks = AddressRemarks;
            item.SanctionDetails = SanctionDetails;
            item.Links = Links;
            item.OtherInformation = OtherInformation;
            item.SourceCountry = SourceCountry;

            return item;
        }
    }
}
