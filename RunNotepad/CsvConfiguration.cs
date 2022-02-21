namespace RunNotepad
{
    internal class CsvConfiguration
    {
        private object invariantCulture;

        public CsvConfiguration(object invariantCulture)
        {
            this.invariantCulture = invariantCulture;
        }

        public bool HasHeaderRecord { get; set; }
    }
}