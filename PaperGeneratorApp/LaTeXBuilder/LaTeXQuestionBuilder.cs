using PaperGeneratorApp.Models;
using System.Text;

namespace PaperGeneratorApp.LaTeXBuilder
{
    public class LaTeXQuestionBuilder : IQuestionBuilder
    {
        public StringBuilder BuildQuestions(IEnumerable<Question> questions)
        {
            StringBuilder questionsBuilder = new StringBuilder();
            foreach (var question in questions)
            {
                questionsBuilder.AppendLine("\\item " + question.QuestionText + " :");

                // Include image if available
                if (!string.IsNullOrEmpty(question.QuestionImageURL))
                {
                    //Console.WriteLine(question.QuestionImageURL);
                    string fileName = Path.GetFileName(question.QuestionImageURL);

                    questionsBuilder.AppendLine($"\n\\includegraphics[width = 0.25\\textwidth]{{{fileName}}}\r\n");
                }

                // Add answer options
                questionsBuilder.AppendLine("\\begin{tasks}(2)");
                foreach (var answer in question.AnswerOptions)
                {
                    questionsBuilder.AppendLine("\\task " + answer.AnswerText);
                }
                questionsBuilder.AppendLine("\\end{tasks}");
            }
            return questionsBuilder;
        }
    }
}
