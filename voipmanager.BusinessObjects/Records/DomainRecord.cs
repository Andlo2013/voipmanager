using voipmanager.enums;

namespace voipmanager.BusinessObjects.Records
{
    public record DomainRecord
    {
        public int Id { get; init; }

        //The task to which the record belongs
        public int TaskId { get; init; }

        //Max 60
        //Unique at general
        public string Name { get; init; }

        //Max 40
        public string Description { get; init; }

        //Max 40
        public string EmailSender { get; init; }

        //Yes-No
        public YesOrNo Residential { get; init; }

        //Active-Locked
        public string Status { get; init; }

        //Combo options
        public int DialPermissionId { get; init; }

        //Combo
        public int TimeZoneId { get; init; }

        //Maximum 3 digits
        public int AreaCode { get; init; }

        //Max 40 characters
        public string CallerName { get; init; }

        //The number to show when make a call (Max 40)
        public string CallerId { get; init; }

        public bool EnableVoiceMail { get; init; }

        //Enabled-disabled
        public EnabledOrDisabled VoiceMailTranscription { get; init; }

        //Max40
        public string EmergencyCallerId { get; init; }
    }
}
