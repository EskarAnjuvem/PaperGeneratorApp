namespace PaperGeneratorApp.Services
{
    public class FileService : IFileService
    {
        public void CreateDirectory(string path) => Directory.CreateDirectory(path);

        public void Delete(string path) => File.Delete(path);

        public bool Exists(string path) => File.Exists(path);

        public void Move(string sourcePath, string destinationPath) => File.Move(sourcePath, destinationPath);

        public void WriteAllText(string path, string content) => File.WriteAllText(path, content);
    }
}
