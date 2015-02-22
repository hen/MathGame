using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Speed_Test
{

    // TODO: Division quiz, prime number quiz ('or' is the text), addition, subtraction
    // TODO: Selector for the quizzes
    // TODO: Figure out the UI for more than 2 operands
    // TODO: Show the correct and incorrect score.
    // TODO: Better UI for the log of the test. Simple window with a folded up section showing all the results. Show tabular and not in a list. Add scrolly.
    // TODO: Add a title to a quiz so it can be shown in results

    public partial class SpeedTest : Form
    {
        int TOTAL = 40; // TODO: Move this inside Quiz?
        Random randomizer = new Random();
        int secondsLeft; // TODO: Move this inside QuizData?
        int completedCount; // TODO: Move this inside QuizData
        int correctCount;  // TODO: Move this inside QuizData
        QuizData data;
        Quiz quiz;

        public SpeedTest()
        {
            InitializeComponent();
            this.answerField.Controls.RemoveAt(0);
        }

        public void StartTheTest() {
            data = new QuizData(TOTAL);
            quiz = new AdditionQuiz();
            operationLabel.Text = quiz.operatorText();
            completedCount = 0;
            correctCount = 0;
            completedLabel.Text = "" + completedCount;
            secondsLeft = 60;
            timeRemaining.Text = secondsLeft + " seconds";

            NewQuestion();

            timer1.Start();
        }

        private void NewQuestion()
        {
            int[] operands = quiz.nextOperands(randomizer);
            operand1.Text = operands[0].ToString();
            operand2.Text = operands[1].ToString();
            answerField.Value = 0;
            answerField.Select(0, 1);
        }

        private bool CheckTheAnswer()
        {
           return (quiz.solution() == answerField.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (secondsLeft > 0)
            {
                secondsLeft = secondsLeft - 1;
                timeRemaining.Text = secondsLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeRemaining.Text = "Time's up!";

                NextButton.Enabled = false;
                startButton.Enabled = true;

                ResultsForm rForm = new ResultsForm();
                rForm.timesUp(correctCount, data.report());
                rForm.Show();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheTest();
            startButton.Enabled = false;
            answerField.Select();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void NextQuestion() {
        
            if (answerField.Value.Equals("0")) {
               return; // FIXME: not working!!
            }

            completedCount++;
            completedLabel.Text = "" + completedCount;
            if (CheckTheAnswer()) correctCount++;
            data.logSolution(operand1.Text + " " + operationLabel.Text + " " + operand2.Text, (int)answerField.Value, quiz.solution());
            if (completedCount == TOTAL)
            {
                timer1.Stop();
                startButton.Enabled = true;
                NextButton.Enabled = false;
                ResultsForm rForm = new ResultsForm();
                rForm.finished(correctCount, data.report());
                rForm.Show();
            }
            else
            {
                NewQuestion();
            }
        }

        private void key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                NextQuestion();
            }
        }
    }

    public interface Quiz
    {
        String operatorText();
        int solution();
        int[] nextOperands(Random rnd);
    }

    public class MultiplicationQuiz : Quiz
    {
        private int answer;

        public String operatorText() { return "×"; }

        public int solution() { return this.answer; }

        public int[] nextOperands(Random rnd)
        {
            int[] operands = new int[2];
            operands[0] = rnd.Next(10) + 1;
            operands[1] = rnd.Next(10) + 1;
            this.answer = operands[0] * operands[1];
            return operands;
        }
    }

    public class DivisionQuiz : Quiz
    {
        private int answer;

        public String operatorText() { return "÷"; }

        public int solution() { return this.answer; }

        public int[] nextOperands(Random rnd)
        {
            int[] operands = new int[2];
            operands[1] = rnd.Next(10) + 1;
            this.answer = rnd.Next(10) + 1;
            operands[0] = this.answer * operands[1];
            return operands;
        }
    }

    public class AdditionQuiz : Quiz
    {
        private int answer;

        public String operatorText() { return "+"; }

        public int solution() { return this.answer; }

        public int[] nextOperands(Random rnd)
        {
            int[] operands = new int[2];
            operands[0] = rnd.Next(20) + 1;
            operands[1] = rnd.Next(20) + 1;
            this.answer = operands[0] + operands[1];
            return operands;
        }
    }

    public class SubtractionQuiz : Quiz
    {
        private int answer;

        public String operatorText() { return "-"; }

        public int solution() { return this.answer; }

        public int[] nextOperands(Random rnd)
        {
            int[] operands = new int[2];
            operands[0] = rnd.Next(20) + 2;
            operands[1] = rnd.Next(operands[0] - 1) + 1;
            this.answer = operands[0] - operands[1];
            return operands;
        }
    }

    public class QuizData
    {

        Solution[] questions;
        int currentQuestion = 0;

        public QuizData(int questionCount)
        {
            questions = new Solution[questionCount];
        }

        public void logSolution(String question, int providedAnswer, int correctAnswer)
        {
            questions[currentQuestion] = new Solution(question, providedAnswer, correctAnswer);
            currentQuestion++;
        }

        public Solution getAnswer(int index) { return questions[index]; }
        public int answerCount() { return currentQuestion; }

        public String report()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < currentQuestion; i++)
            {
                sb.Append(questions[i].report());
                sb.Append("\n");
            }
            return sb.ToString();
        }

    }

    public class Solution
    {
        private String question;
        private int providedAnswer;
        private int correctAnswer;
        private Boolean correct;

        public Solution(String question, int providedAnswer, int correctAnswer)
        {
            this.question = question;
            this.providedAnswer = providedAnswer;
            this.correctAnswer = correctAnswer;
            this.correct = (providedAnswer == correctAnswer);
        }

        public String report()
        {
            return "" + question + " = " + providedAnswer + " " + (correct ? "RIGHT" : "WRONG -> " + correctAnswer);
        }
    }
}
