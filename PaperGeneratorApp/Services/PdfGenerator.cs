using PaperGeneratorApp.Input;
using PaperGeneratorApp.Log;

namespace PaperGeneratorApp.Services
{
    public class PdfGenerator
    {
        private readonly IFileService _fileService;
        private readonly IProcessService _processService;
        private readonly string _pdflatexPath;
        private readonly ILogger _logger;
        private readonly IOutputProvider _outputProvider;

        public PdfGenerator(IFileService fileService, IProcessService processService, string pdflatexPath, ILogger logger, IOutputProvider outputProvider)
        {
            _fileService = fileService;
            _processService = processService;
            _pdflatexPath = pdflatexPath;
            _logger = logger;
            _outputProvider = outputProvider;
        }

        public void GeneratePdf(string latexContent, string outputDir)
        {
            try
            {
                _fileService.CreateDirectory(outputDir);
                string latexFilePath = Path.Combine(outputDir, "temp.tex");
                _fileService.WriteAllText(latexFilePath, latexContent);

                string arguments = $"-output-directory=\"{outputDir}\" \"{latexFilePath}\"";
                bool success = _processService.Start(_pdflatexPath, arguments, out string output, out string error);

                if (success)
                {
                    _outputProvider.WriteLine("Pdf Generated Successfully!");
                }
                else
                {
                    _logger.Log("Error: " + error);
                }

                string tempPath = Path.Combine(outputDir, "temp.pdf");
                string destPath = Path.Combine(outputDir, "output.pdf");

                MoveFile(tempPath, destPath);
                CleanUpAuxiliaryFiles(outputDir);
            }
            catch (Exception e)
            {
                _logger.Log("Error : " + e.Message);
            }
        }

        public void MoveFile(string tempPath, string destPath)
        {
            if (_fileService.Exists(tempPath))
            {
                if (_fileService.Exists(destPath))
                {
                    _fileService.Delete(destPath);
                    _outputProvider.WriteLine("Existing output file deleted.");
                }
                _fileService.Move(tempPath, destPath);
            }
        }

        public void CleanUpAuxiliaryFiles(string outputDirectory)
        {
            _outputProvider.WriteLine("Trying to delete auxiliary files....");
            foreach (string ext in new[] { "aux", "log", })
            {
                string tempFile = Path.Combine(outputDirectory, $"temp.{ext}");

                if (_fileService.Exists(tempFile))
                {
                    _fileService.Delete(tempFile);
                }
            }
        }
    }
}
