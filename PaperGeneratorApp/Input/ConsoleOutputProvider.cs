namespace PaperGeneratorApp.Input
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        public void Write(string message) => Console.Write(message);

        public void WriteLine(string message) => Console.WriteLine(message);
    }
}