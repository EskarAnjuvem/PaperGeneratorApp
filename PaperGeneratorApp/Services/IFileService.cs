namespace PaperGeneratorApp.Services
{
    public interface IFileService
    {
        void WriteAllText(string path, string content);
        void CreateDirectory(string path);
        bool Exists(string path);
        void Delete(string path);
        void Move(string sourcePath, string destinationPath);
    }
}