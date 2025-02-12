using System.Text;

namespace PaperGeneratorApp.LaTeXBuilder
{
    public class LaTeXPreamble : IPreambleBuilder
    {
        private readonly string _docType;
        private readonly string _author;
        private readonly string _title;
        private readonly string _subject;

        public LaTeXPreamble(string docType, string author, string title, string subject)
        {
            _docType = docType;
            _author = author;
            _title = title;
            _subject = subject;
        }
        public StringBuilder BuildPreamble()
        {
            StringBuilder preamble = new StringBuilder();

            preamble.Append(
                $"\\documentclass{{{_docType}}}\r\n\\usepackage[a4paper, total={{7in, 9in}}]{{geometry}}\r\n\\usepackage{{amsmath}}\r\n\\usepackage{{graphicx}}\r\n\\graphicspath{{{{D:/Computer Science/Projects/QuestionPaper/LaTeXFiles/Images/}}}}\r\n\\usepackage{{enumitem}}\r\n\\usepackage{{multicol}}\r\n\\usepackage{{adjustbox}}\r\n\\usepackage{{tasks}}\r\n\\title{{\r\n    {_title}\\\\\r\n    \\vspace{{0.2cm}}\r\n    \\large {_subject} % Adds another centered line below the main title\r\n}}\r\n\\author{{{_author}\\thanks{{Academy Of Physics.}}}}\r\n\\date{{}}\r\n\\begin{{document}}\r\n\\maketitle\r\n\\begin{{enumerate}}\r\n");

            return preamble;
        }
    }
}
