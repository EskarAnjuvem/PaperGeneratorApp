namespace PaperGeneratorApp.Input
{
    public interface IOutputProvider
    {
        void Write(string message);
        void WriteLine(string message);
    }
}
