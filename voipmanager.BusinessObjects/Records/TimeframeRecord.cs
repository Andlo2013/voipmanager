namespace voipmanager.BusinessObjects.Records
{
    public record TimeframeRecord
    {
        public int Id { get; init; }

        //Id of the task
        public int TaskId { get; init; }

        //Timeframe's name
        public string Name { get; init; }

        public IEnumerable<TimeframeDetailRecord> Details { get; init; }

    }
}
