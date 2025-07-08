using System.Runtime.Serialization;

namespace DilisenseApi.Models {
    public enum SourceType {
        [EnumMember(Value = "SANCTION")]
        Sanction,
        [EnumMember(Value = "PEP")]
        PEP,
        [EnumMember(Value = "CRIMINAL")]
        Criminal,
        [EnumMember(Value = "OTHER")]
        Other,
    }

    public enum PEPType {
        [EnumMember(Value = "POLITICIAN")]
        Politician,
        [EnumMember(Value = "JUDGE")]
        Judge,
        [EnumMember(Value = "BOARD_MEMBER_OF_CENTRAL_BANK")]
        BoardMemberOfCentralBank,
        [EnumMember(Value = "EXECUTIVE_AUDITOR")]
        ExecutiveAuditor,
        [EnumMember(Value = "ADMINISTRATION_OFFICE_EXECUTIVE")]
        AdministrationOfficeExecutive,
        [EnumMember(Value = "MILITARY_OFFICIAL")]
        MilitaryOfficial,
        [EnumMember(Value = "EMBASSY_OFFICIAL")]
        EmbassyOfficial,
        [EnumMember(Value = "INTERNATIONAL_ORGANIZATION_OFFICIAL")]
        InternationalOrganizationOfficial,
        [EnumMember(Value = "RELATIVES_AND_CLOSE_ASSOCIATES")]
        RelativesAndCloseAssociates,
        [EnumMember(Value = "STATE_OWNED_ENTERPRISE")]
        StateOwnedEnterprise,
        [EnumMember(Value = "BOARD_MEMBER_OF_STATE_OWNED_ENTERPRISE")]
        BoardMemberOfStateOwnedEnterprise,
        [EnumMember(Value = "PROSECUTION_OFFICIAL")]
        ProsecutionOfficial,
        [EnumMember(Value = "AGENCY_OFFICIAL")]
        AgencyOfficial,
        [EnumMember(Value = "OTHER")]
        Other,
    }

    public enum EntityType {
        [EnumMember(Value = "INDIVIDUAL")]
        Individual,
        [EnumMember(Value = "ENTITY")]
        Entity,
        [EnumMember(Value = "VESSEL")]
        Vessel,
        [EnumMember(Value = "AIRCRAFT")]
        Aircraft,
        [EnumMember(Value = "OBJECT")]
        Object,
        [EnumMember(Value = "UNKNOWN")]
        Unknown,
    }

    public enum Gender {
        [EnumMember(Value = "FEMALE")]
        Female,
        [EnumMember(Value = "MALE")]
        Male,
        [EnumMember(Value = "UNKNOWN")]
        Unknown,
    }
}
