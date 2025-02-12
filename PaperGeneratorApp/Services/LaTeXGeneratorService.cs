using PaperGeneratorApp.LaTeXBuilder;
using PaperGeneratorApp.Models;
using System.Text;

namespace PaperGeneratorApp.Services
{
    public class LaTeXGeneratorService
    {
        private readonly IPreambleBuilder _preambleBuilder;
        private readonly IQuestionBuilder _questionBuilder;

        public LaTeXGeneratorService(IPreambleBuilder preambleBuilder, IQuestionBuilder questionBuilder)
        {
            _preambleBuilder = preambleBuilder;
            _questionBuilder = questionBuilder;
        }

        public string GenerateLaTeXFile(IEnumerable<Question> questions)
        {
            StringBuilder latexFile = _preambleBuilder.BuildPreamble();
            latexFile.Append(_questionBuilder.BuildQuestions(questions));
            latexFile.AppendLine("\\end{enumerate}");
            latexFile.AppendLine("\\end{document}");

            return latexFile.ToString();
        }


    }
}
