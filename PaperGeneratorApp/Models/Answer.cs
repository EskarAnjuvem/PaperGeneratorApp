﻿namespace PaperGeneratorApp.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string? AnswerText { get; set; }
        public string? AnswerImageURL { get; set; }
        public bool IsCorrect { get; set; }
    }
}
