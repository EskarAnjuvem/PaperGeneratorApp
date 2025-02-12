namespace PaperGeneratorApp.Input
{
    internal class ConsoleInputProvider : IInputProvider
    {
        public string? ReadLine() => Console.ReadLine();

    }
}
