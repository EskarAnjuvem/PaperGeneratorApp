using System.Text;

namespace PaperGeneratorApp.LaTeXBuilder
{
    public interface IPreambleBuilder
    {
        StringBuilder BuildPreamble();
    }
}
