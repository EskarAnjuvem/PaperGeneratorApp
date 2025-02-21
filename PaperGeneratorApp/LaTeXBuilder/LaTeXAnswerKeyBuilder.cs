using PaperGeneratorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperGeneratorApp.LaTeXBuilder
{
    public class LaTeXAnswerKeyBuilder : IAnswerKeyBuilder
    {
        public StringBuilder BuildAnswerKey(IEnumerable<Question> questions)
        {
            StringBuilder answerKeyBuilder = new StringBuilder();
            answerKeyBuilder.AppendLine("\\pagebreak\r\n\\centering \\section*{Answer Key} \r\n\\begin{tasks}[style=enumerate,after-item-skip=5mm](4)");
            foreach (var question in questions)
            {
                char option = 'A';
                foreach (var answer in question.AnswerOptions)
                {
                    if (answer.IsCorrect)
                    {
                        break;                        
                    }
                    else
                    {
                        option++;
                    }
                }
                answerKeyBuilder.AppendLine($"\\task \\textit{{{option}}}");
            }
            answerKeyBuilder.AppendLine("\\end{tasks}");
            return answerKeyBuilder;
        }
    }
}
