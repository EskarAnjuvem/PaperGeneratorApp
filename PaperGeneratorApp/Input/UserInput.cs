using PaperGeneratorApp.Log;

namespace PaperGeneratorApp.Input
{
    public class UserInput
    {
        private readonly IInputProvider _inputProvider;
        private readonly IOutputProvider _outputProvider;
        private readonly UserInputConfig _config;
        private readonly ILogger _logger;

        public UserInput(IInputProvider inputProvider, IOutputProvider outputProvider, UserInputConfig config, ILogger logger)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _config = config;
            _logger = logger;
        }
        public int NumberOfQuestions { get; private set; }
        public string DifficultyLevel { get; private set; }
        public string Subject { get; private set; }
        public bool NeedAnswerKey { get; private set; }

        public void GetUserInput()
        {
            try
            {
                NumberOfQuestions = GetNumberOfQuestions();
                DifficultyLevel = GetDifficultyLevel();
                Subject = GetSubject();
                NeedAnswerKey = GetAnswerKeyRequirement();
            }
            catch (Exception ex)
            {
                _logger.Log($"ERROR: {ex.Message}");
            }

        }

        private bool GetAnswerKeyRequirement()
        {
            _outputProvider.Write("Do you need an Answer Key ? (yes/no) : ");
            string? answerKeyInput = _inputProvider.ReadLine()?.Trim().ToLower();
            NeedAnswerKey = answerKeyInput == "yes";
            return NeedAnswerKey;
        }

        private string GetSubject()
        {
            _outputProvider.Write("Enter the Subject concerned : ");
            Subject = _inputProvider.ReadLine() ?? _config.DefaultSubject;
            return Subject;
        }

        private string GetDifficultyLevel()
        {
            _outputProvider.Write("Enter the Difficulty Level of Questions required (Options- Easy, Medium, Hard) : ");
            string? difficultyLevel = _inputProvider.ReadLine() ?? "Easy";
            if (new[] { "Easy", "Medium", "Hard" }.Contains(difficultyLevel, StringComparer.OrdinalIgnoreCase))
            {
                return difficultyLevel;
            }
            else
            {
                _outputProvider.WriteLine($"Invalid Input. Using Default Value of {_config.DefaultDifficultyLevel}");
                return _config.DefaultDifficultyLevel;
            }
        }

        private int GetNumberOfQuestions()
        {
            _outputProvider.Write("Enter the number of Questions required : ");
            string? numberInput = _inputProvider.ReadLine();
            if (int.TryParse(numberInput, out int number) && number > 0)
            {
                return number;
            }
            else
            {
                _outputProvider.WriteLine($"Invalid Input. Using Default Value of {_config.DefaultNumberOfQuestions}");
                return _config.DefaultNumberOfQuestions;
            }
        }
    }
}
