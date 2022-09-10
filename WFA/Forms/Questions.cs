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
            InitializateAnswerButtons();
            SetupQuestion();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            // Get clicked button and its index
            Button clickedButton = sender as Button;
            int clickedButtonIndex = answerButtons.IndexOf(clickedButton);

            // Determinate if the index of the clicked button corresponds to
            // the index of the current question. If not then end the game.
            if (clickedButtonIndex != GameManager.currentQuestion.correntAnswerIndex)
            {
                MessageBox.Show("Wrong answer - Game over");
                Close();
                return;
            }

            // Determinate if exists a next question to continue the game.
            if (GameManager.NextQuestion())
            {
                SetupQuestion();
                return;
            }

            // If there is not next question the user has won.
            MessageBox.Show("You won");
            Close();
        }

        private void SetupQuestion()
        {
            // Setup on the UI the next question
            Question currentQuestion = GameManager.currentQuestion;
            questionLabel.Text = currentQuestion.question;
            answer1Button.Text = currentQuestion.answers[0];
            answer2Button.Text = currentQuestion.answers[1];
            answer3Button.Text = currentQuestion.answers[2];
            answer4Button.Text = currentQuestion.answers[3];

            // Enable all the answer buttons because some of the could be
            // disabled by using game helps as change answers, 50/50 or call a friend
            foreach (var answerButton in answerButtons)
            {
                answerButton.Enabled = true;
            }
        }

        private void InitializateAnswerButtons()
        {
            // Add the answer buttons to a list and add the same event to each button.
            answerButtons.AddRange(new List<Button>() { answer1Button, answer2Button, answer3Button, answer4Button });
            foreach (var answerButton in answerButtons)
            {
                answerButton.Click += new EventHandler(answerButton_Click);
            }
        }

        private void fiftyButton_Click(object sender, EventArgs e)
        {
            // Disable fifty help button so that it can't be user for the rest of the questions. 
            fiftyButton.Enabled = false;

            bool shouldNotBreak;
            int randomIndex;
            Random random = new Random();

            int correntAnswerIndex = GameManager.currentQuestion.correntAnswerIndex;
            List<int> excludedIndexes = new List<int>() { correntAnswerIndex };

            // Generate two random numbers excluding the correct answer index, and the first number
            // that will be generated.
            for (int i = 0; i < 2; i++)
            {
                do
                {
                    randomIndex = random.Next(0, answerButtons.Count);
                    // If generated number is in the excluded indexes list, generate another number.
                    shouldNotBreak = excludedIndexes.Contains(randomIndex) || false;
                }
                while (shouldNotBreak);

                // Add the first generated number to excluded indexes so that can't be generated
                // for the second number generation.
                excludedIndexes.Add(randomIndex);

                // Disable the answer button that corresponds to the generated number.
                answerButtons[randomIndex].Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            // Disable change help button so that it can't be user for the rest of the questions. 
            changeButton.Enabled = false;

            // If a next question exists, then setup the UI. If not, the user has won because is the last question.
            if (GameManager.NextQuestion())
            {
                SetupQuestion();
                return;
            }

            MessageBox.Show("You won");
            Close();

        }

        private void callButton_Click(object sender, EventArgs e)
        {
            // Disable call help button so that it can't be user for the rest of the questions. 
            callButton.Enabled = false;

            Random random = new Random();

            // Pick a random question and show it
            List<string> answers = GameManager.currentQuestion.answers;
            int randomIndex = random.Next(0, answers.Count);
            string message = "I don't know, man. I think is: " + answers[randomIndex];
            MessageBox.Show(message);
        }
    }
}
