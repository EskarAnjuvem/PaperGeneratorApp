using PaperGeneratorApp.Models;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Threading.Tasks;

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
                    double imagewidth = question.QuestionImageWidth;

                    questionsBuilder.AppendLine($"\n\\includegraphics[width = {imagewidth}\\textwidth]{{{fileName}}}\r\n");
                }

                // Add answer options
                questionsBuilder.AppendLine("\\begin{tasks}(2)");
                //char option = 'A';
                foreach (var answer in question.AnswerOptions)
                {
                    if (answer.AnswerText != System.String.Empty)
                    {
                        questionsBuilder.AppendLine("\\task " + answer.AnswerText);
                    }
                    else
                    {                        
                        string answerImageFileName = Path.GetFileName(answer.AnswerImageURL);
                        questionsBuilder.AppendLine($"\\task \\begin{{minipage}} {{0.25\\textwidth}} \\includegraphics[width=0.8\\textwidth]{{{answerImageFileName}}}\\end{{minipage}}");                        
                    }
                    //if (!answer.IsCorrect)
                    //{
                    //    option++;
                    //}
                }
                questionsBuilder.AppendLine("\\end{tasks}");
            }
            return questionsBuilder;
        }
    }
}
