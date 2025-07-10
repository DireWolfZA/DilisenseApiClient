namespace DilisenseApi.Models {
    public enum SourceType {
        Sanction,
        PEP,
        Criminal,
        Other,
    }

    public enum PEPType {
        Politician,
        Judge,
        BoardMemberOfCentralBank,
        ExecutiveAuditor,
        AdministrationOfficeExecutive,
        MilitaryOfficial,
        EmbassyOfficial,
        InternationalOrganizationOfficial,
        RelativesAndCloseAssociates,
        StateOwnedEnterprise,
        BoardMemberOfStateOwnedEnterprise,
        ProsecutionOfficial,
        AgencyOfficial,
        Other,
    }

    public enum EntityType {
        Individual,
        Entity,
        Vessel,
        Aircraft,
        Object,
        Unknown,
    }

    public enum Gender {
        Female,
        Male,
        Unknown,
    }
}
