using voipmanager.enums;

namespace voipmanager.BusinessObjects.Records
{
    public record TimeframeDetailRecord
    {
        //Id 
        public int Id { get; init; }

        //Timeframe id
        public int TimeframeId { get; init; }

        //Day of the week
        public Days Day { get; init; }

        //Initial hour
        public TimeOnly From { get; init; }

        //End hour
        public TimeOnly To { get; init; }

    }
}
