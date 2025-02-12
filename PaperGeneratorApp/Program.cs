// See https://aka.ms/new-console-template for more information

using PaperGeneratorApp.Data;
using PaperGeneratorApp.Input;
using PaperGeneratorApp.LaTeXBuilder;
using PaperGeneratorApp.Log;
using PaperGeneratorApp.Models;
using PaperGeneratorApp.Services;

string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Ngc2003ub313;Database=quizmaster_db;";
string outputDir = "D:\\Computer Science\\Projects\\PaperGeneratorApp\\PaperGeneratorApp\\Output";
string pdflatexPath = @"C:\Program Files\MiKTeX\miktex\bin\x64\pdflatex.exe";

var fileService = new FileService();
var processService = new ProcessService();

IInputProvider consoleInputProvider = new ConsoleInputProvider();

IOutputProvider consoleOutputProvider = new ConsoleOutputProvider();

UserInputConfig userInputConfig = new UserInputConfig();

ILogger consoleLogger = new ConsoleLogger();

UserInput userInput = new UserInput(consoleInputProvider, consoleOutputProvider, userInputConfig, consoleLogger);

userInput.GetUserInput();

var queryBuilder = new QueryBuilder(userInput);

string query = queryBuilder.BuildQuery();

DatabaseHelper databaseHelper = new DatabaseHelper(connectionString);

List<Question> questionsList = databaseHelper.FetchQuestionsAnswerImages(query);

var preambleBuilder = new LaTeXPreamble("article", "Sanjeev", "Questions", "Physics");
var questionBuilder = new LaTeXQuestionBuilder();
var latexGeneratorService = new LaTeXGeneratorService(preambleBuilder, questionBuilder);

string latexFinalText = latexGeneratorService.GenerateLaTeXFile(questionsList);

PdfGenerator pdfGenerator = new PdfGenerator(fileService, processService, pdflatexPath, consoleLogger, consoleOutputProvider);
pdfGenerator.GeneratePdf(latexFinalText, outputDir);
