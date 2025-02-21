using PaperGeneratorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperGeneratorApp.LaTeXBuilder
{
    public interface IAnswerKeyBuilder
    {
        StringBuilder BuildAnswerKey(IEnumerable<Question> questions);
    }
}
