using PaperGeneratorApp.LaTeXBuilder;
using PaperGeneratorApp.Models;
using System.Text;

namespace PaperGeneratorApp.Services
{
    public class LaTeXGeneratorService
    {
        private readonly IPreambleBuilder _preambleBuilder;
        private readonly IQuestionBuilder _questionBuilder;
        private readonly IAnswerKeyBuilder _answerKeyBuilder;

        public LaTeXGeneratorService(IPreambleBuilder preambleBuilder, IQuestionBuilder questionBuilder)
        {
            _preambleBuilder = preambleBuilder;
            _questionBuilder = questionBuilder;
            _answerKeyBuilder = new LaTeXAnswerKeyBuilder();
        }

        public string GenerateLaTeXFile(IEnumerable<Question> questions, bool NeedAnswerKey = false)
        {
            StringBuilder latexFile = _preambleBuilder.BuildPreamble();
            latexFile.Append(_questionBuilder.BuildQuestions(questions));
            latexFile.AppendLine("\\end{enumerate}");
            if (NeedAnswerKey == true)
            {
                latexFile.Append(_answerKeyBuilder.BuildAnswerKey(questions));
            }
            latexFile.AppendLine("\\end{document}");

            return latexFile.ToString();
        }
    }
}
