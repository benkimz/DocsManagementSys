namespace DocsManagement.Core.Aggregates.AppFileAg
{
    public class AppFile
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Url { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
