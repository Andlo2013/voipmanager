using voipmanager.enums;

namespace voipmanager.BusinessObjects.Records
{
    public record TaskRecord
    {
        //Record Id to follow the pending list
        public int Id { get; init; }

        //User which create the task (Our own user)
        public int UserId { get; init; }

        public TaskState State { get; init; }

        public bool Active { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime UpdatedAt { get; init; }

    }
}
