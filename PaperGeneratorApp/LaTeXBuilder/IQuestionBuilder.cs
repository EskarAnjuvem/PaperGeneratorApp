using PaperGeneratorApp.Models;
using System.Text;

namespace PaperGeneratorApp.LaTeXBuilder
{
    public interface IQuestionBuilder
    {
        StringBuilder BuildQuestions(IEnumerable<Question> questions);
    }
}
