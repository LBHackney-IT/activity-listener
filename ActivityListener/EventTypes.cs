namespace ActivityListener
{
    public static class EventTypes
    {
        public const string AssetCreatedEvent = "AssetCreatedEvent";
        public const string AssetUpdatedEvent = "AssetUpdatedEvent";

        public const string ContractCreatedEvent = "ContractCreatedEvent";
        public const string ContractUpdatedEvent = "ContractUpdatedEvent";

        public const string PersonCreatedEvent = "PersonCreatedEvent";
        public const string PersonUpdatedEvent = "PersonUpdatedEvent";

        public const string PersonAddedToTenureEvent = "PersonAddedToTenureEvent";
        public const string PersonRemovedFromTenureEvent = "PersonRemovedFromTenureEvent";

        public const string ContactDetailAddedEvent = "ContactDetailAddedEvent";
        public const string ContactDetailEditedEvent = "ContactDetailEditedEvent";
        public const string ContactDetailDeletedEvent = "ContactDetailDeletedEvent";

        public const string TenureCreatedEvent = "TenureCreatedEvent";
        public const string TenureUpdatedEvent = "TenureUpdatedEvent";

        public const string HousingApplicationCreatedEvent = "HousingApplicationCreatedEvent";
        public const string HousingApplicationUpdatedEvent = "HousingApplicationUpdatedEvent";

        public const string EqualityInformationCreatedEvent = "EqualityInformationCreatedEvent";
        public const string EqualityInformationUpdatedEvent = "EqualityInformationUpdatedEvent";

        public const string ProcessStartedEvent = "ProcessStartedEvent";
        public const string ProcessUpdatedEvent = "ProcessUpdatedEvent";
        public const string ProcessClosedEvent = "ProcessClosedEvent";
        public const string ProcessCompletedEvent = "ProcessCompletedEvent";

        public const string ProcessStartedAgainstTenureEvent = "ProcessStartedAgainstTenureEvent";
        public const string ProcessStartedAgainstPersonEvent = "ProcessStartedAgainstPersonEvent";

        public const string CautionaryAlertCreatedEvent = "CautionaryAlertCreatedEvent";
        public const string CautionaryAlertEndedEvent = "CautionaryAlertEndedEvent";
        public const string PatchOrAreaResEntityEditedEvent = "PatchOrAreaResEntityEditedEvent";

        public const string NoteCreatedAgainstProcessEvent = "NoteCreatedAgainstProcessEvent";
        public const string NoteCreatedAgainstTenureEvent = "NoteCreatedAgainstTenureEvent";
        public const string NoteCreatedAgainstPersonEvent = "NoteCreatedAgainstPersonEvent";
        public const string NoteCreatedAgainstAssetEvent = "NoteCreatedAgainstAssetEvent";
    }
}
