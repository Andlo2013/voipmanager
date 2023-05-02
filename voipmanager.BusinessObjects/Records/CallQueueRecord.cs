using voipmanager.enums;

namespace voipmanager.BusinessObjects.Records
{
    public record CallQueueRecord
    {
        public int Id { get; init; }

        public string Name { get; init; }

        //Combo
        public int SiteId { get; init; }

        public int Extension { get; init; }

        //Combo
        public int TypeId { get; init; }

        public YesOrNo RecordCalls { get; init; }

        public YesOrNo Statistic { get; init; }

        public YesOrNo RequireAgent { get; init; }

        public int ForwardIfUnavailable { get; init; }

        public int ForwardIfUnanswered { get; init; }

        public int QueueRingTimeout { get; init; }

        public YesOrNo Voicemail { get; init; }

    }
}
