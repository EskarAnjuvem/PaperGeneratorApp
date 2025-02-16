using PaperGeneratorApp.Input;

namespace PaperGeneratorApp.Data
{
    public class QueryBuilder
    {
        private readonly UserInput _userInput;
        public QueryBuilder(UserInput userInput)
        {
            _userInput = userInput;
        }
        public string BuildQuery()
        {
            //string query = $"SELECT question_text, questions.image_id AS question_image FROM questions LIMIT {_userInput.NumberOfQuestions};";

            //string queryQuestionAndImage = $"SELECT question_text, i.image_path AS question_image FROM questions LEFT JOIN images i ON questions.image_id = i.image_id LIMIT {_userInput.NumberOfQuestions*4};";

            string queryQuesAnsImg = $"SELECT q.question_id, q.question_text, i.image_path AS question_image, a.answer_text , a.is_correct FROM questions q LEFT JOIN images i ON q.image_id = i.image_id LEFT JOIN answers a ON q.question_id = a.question_id ORDER BY q.question_id, answer_id LIMIT {_userInput.NumberOfQuestions * 4};";

            string queryQuesAnsWithImgOptions = $"SELECT q.question_id, q.question_text,\r\n\t   i.image_path AS question_image,\r\n\t   a.answer_text , ai.image_path as answer_image, a.is_correct,i.default_width\r\nFROM questions q \r\nLEFT JOIN images i ON q.image_id = i.image_id\r\nLEFT JOIN answers a ON q.question_id = a.question_id\r\nLEFT JOIN images ai ON a.answer_image_id = ai.image_id\r\nORDER BY q.question_id, answer_id LIMIT {_userInput.NumberOfQuestions * 4};";

            return queryQuesAnsWithImgOptions;
        }
    }
}
