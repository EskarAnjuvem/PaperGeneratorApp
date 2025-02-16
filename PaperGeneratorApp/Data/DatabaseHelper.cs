using Npgsql;
using PaperGeneratorApp.Models;
using System.Data;
using System.Text;

namespace PaperGeneratorApp.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        private StringBuilder latexQuesAns = new StringBuilder();

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DatabaseHelper(string connectionString, StringBuilder latex)
        {
            _connectionString = connectionString;
            latexQuesAns = latex;
        }
        public List<Question> FetchQuestionsAnswerImages(string query)
        {
            List<Question> questionsList = new List<Question>();
            Question currentQuestion = new Question();
            currentQuestion.Id = -1;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
                {
                    Console.WriteLine("Establishing database connection....");
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection Successful");
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            Console.WriteLine("Command Acquired....");
                            Console.WriteLine("Executing Reader...");
                            using (NpgsqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string questionText = reader.GetString("question_text");
                                    int questionId = Convert.ToInt32(reader["question_id"]);

                                    string questionImageURL = Convert.ToString(reader["question_image"]);
                                    if (currentQuestion.Id != questionId)
                                    {
                                        currentQuestion = new Question
                                        {
                                            Id = questionId,
                                            QuestionText = questionText
                                        };
                                        if (!string.IsNullOrEmpty(questionImageURL))
                                        {
                                            currentQuestion.QuestionImageURL = questionImageURL;
                                            currentQuestion.QuestionImageWidth = (double)reader["default_width"];
                                        }
                                        if (reader["answer_text"].ToString() != String.Empty)
                                        {                                            
                                            currentQuestion.AnswerOptions.Add(new Answer
                                            {
                                                AnswerText = reader["answer_text"].ToString(),
                                                IsCorrect = (bool)reader["is_correct"],
                                                AnswerImageURL = ""
                                            });
                                        }
                                        else if (reader["answer_image"] != null)
                                        {                                            
                                            currentQuestion.AnswerOptions.Add(new Answer
                                            {
                                                AnswerText = "",
                                                IsCorrect = (bool)reader["is_correct"],
                                                AnswerImageURL = reader["answer_image"].ToString()
                                            });
                                        }                                        
                                        questionsList.Add(currentQuestion);
                                    }
                                    else
                                    {
                                        if (reader["answer_text"].ToString() != String.Empty)
                                        {
                                            currentQuestion.AnswerOptions.Add(new Answer
                                            {
                                                AnswerText = reader["answer_text"].ToString(),
                                                IsCorrect = (bool)reader["is_correct"],
                                                AnswerImageURL = ""
                                            });
                                        }
                                        else
                                        {
                                            currentQuestion.AnswerOptions.Add(new Answer
                                            {
                                                AnswerText = "",
                                                IsCorrect = (bool)reader["is_correct"],
                                                AnswerImageURL = reader["answer_image"].ToString()
                                            });
                                        }
                                        //currentQuestion.AnswerOptions.Add(new Answer
                                        //{
                                        //    AnswerText = reader["answer_text"].ToString(),
                                        //    IsCorrect = (bool)reader["is_correct"],
                                        //    AnswerImageURL = reader["answer_image_id"].ToString()
                                        //});
                                    }
                                }
                                Console.WriteLine("Completed Reading Records Sucessfully.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return questionsList;
        }
    }
}
