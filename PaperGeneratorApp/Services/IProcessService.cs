namespace PaperGeneratorApp.Services
{
    public interface IProcessService
    {
        bool Start(string fileName, string arguments, out string output, out string error);
    }
}