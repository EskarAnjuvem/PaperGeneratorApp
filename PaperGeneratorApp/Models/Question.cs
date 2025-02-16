namespace PaperGeneratorApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string? QuestionImageURL { get; set; }
        public double QuestionImageWidth { get; set; }
        public List<Answer> AnswerOptions { get; set; } = new List<Answer>();


    }
}