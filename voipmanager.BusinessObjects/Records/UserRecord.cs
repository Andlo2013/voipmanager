namespace voipmanager.BusinessObjects.Records
{
    public record UserRecord
    {
        public int Id { get; init; }

        //The task to which the record belongs
        public int TaskId { get; init; }

        //First Name
        //Max(100)
        public string FirstName { get; init; }

        //Initial range to create Users
        public int ExtensionStart { get; init; }

        //End range to create users
        public int ExtensionEnd { get; init; }

        //Initial range to create autoattendant
        public int AutoAttendantStart { get; init; }

        //End range to create autoattendant
        public int AutoAttendantEnd { get; init; }

        public int CallQueue { get; init; }

        //Combo
        //Confirm if it is the domain or site, in the request is asking domain
        public string Domain { get; init; }

        //Combo
        public int UserScopeId { get; init; }

        //Max 75
        public string EmailAddress { get; init; }

        //Max 40
        public string LoginDomain { get; init; }

        //Max 50 
        public string Password { get; init; }

        //Max 50 
        public string ConfirmPassword { get; init; }

        public string CallerId { get; init; }

        //Always 25800, consider move to a initting table
        public string VoiceMailPin { get; init; }
    }
}
