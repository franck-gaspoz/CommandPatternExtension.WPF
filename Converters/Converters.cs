namespace CommandPatternExtension.WPF.Converters
{
    public static class Converters
    {
        public static MultiCommandContextConverter MultiCommandContextConverter { get; }
            = new MultiCommandContextConverter();
        public static MultiUICommandConverter MultiUICommandConverter { get; }
            = new MultiUICommandConverter();
        public static NewCommandContextConverter NewCommandContextConverter { get; }
            = new NewCommandContextConverter();
    }
}
