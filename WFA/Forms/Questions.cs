using System;
using System.Windows.Forms;
using System.Collections.Generic;
using WFA.Models;

namespace WFA.Forms
{
    public partial class Questions : Form
    {
        List<Button> answerButtons = new List<Button>();

        public Questions()
        {
            InitializeComponent();
            InitializateAnswerButtonsClickEvent();
            SetupQuestion();
        }

        private void OnClickAnswer(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int clickedButtonIndex = answerButtons.IndexOf(clickedButton);
            if (clickedButtonIndex == GameManager.currentQuestion.correntAnswerIndex)
            {
                if (GameManager.NextQuestion())
                {
                    SetupQuestion();
                }
                else
                {
                    MessageBox.Show("You won");
                    Close();
                }
                return;
            }
            MessageBox.Show("Wrong answer - Game over");
            Close();
        }

        private void SetupQuestion()
        {
            Question currentQuestion = GameManager.currentQuestion;
            questionLabel.Text = currentQuestion.question;
            answer1Button.Text = currentQuestion.answers[0];
            answer2Button.Text = currentQuestion.answers[1];
            answer3Button.Text = currentQuestion.answers[2];
            answer4Button.Text = currentQuestion.answers[3];

            foreach (var answerButton in answerButtons)
            {
                answerButton.Enabled = true;
            }
        }

        private void InitializateAnswerButtonsClickEvent()
        {
            answerButtons.AddRange(new List<Button>() { answer1Button, answer2Button, answer3Button, answer4Button });
            foreach (var answerButton in answerButtons)
            {
                answerButton.Click += new EventHandler(OnClickAnswer);
            }
        }

        private void fiftyButton_Click(object sender, EventArgs e)
        {
            fiftyButton.Enabled = false;

            int correntAnswerIndex = GameManager.currentQuestion.correntAnswerIndex;

            List<int> excludedIndexes = new List<int>() { correntAnswerIndex };

            Random random = new Random();

            bool shouldNotBreak;
            int randomIndex;

            for (int i = 0; i < 2; i++)
            {
                do
                {
                    randomIndex = random.Next(0, answerButtons.Count);
                    // If generated number is in the list, generate another number
                    shouldNotBreak = excludedIndexes.Contains(randomIndex) || false;
                }
                while (shouldNotBreak);
                excludedIndexes.Add(randomIndex);
                answerButtons[randomIndex].Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeButton.Enabled = false;
            if (GameManager.NextQuestion())
            {
                SetupQuestion();
            }
            else
            {
                MessageBox.Show("You won");
                Close();
            }
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<string> answers = GameManager.currentQuestion.answers;
            callButton.Enabled = false;
            int randomIndex = random.Next(0, answers.Count);
            string message = "No sé, men, yo creo que es: " + answers[randomIndex];
            MessageBox.Show(message);
        }
    }
}
