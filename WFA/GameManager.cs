using System.Collections.Generic;
using WFA.Models;

namespace WFA
{
    static class GameManager
    {
        public static List<Question> questions = new List<Question>();
        public static Question currentQuestion;
        private static int currentQuestionIndex = 0;

        public static void InitGame()
        {
            questions.Clear();
            currentQuestionIndex = 0;

            // FIRST QUESTION
            Question question1 = new Question(
                "What is the name of the clown in the movie IT?",
                new List<string>() { "Pennywise", "Joker", "Krusty", "Spaulding" },
                0
            );
            questions.Add(question1);
            currentQuestion = question1;

            // SECOND QUESTION
            Question question2 = new Question(
                "What is the name of the fairy in the Disney movie Peter Pan?",
                new List<string>() { "Wendy", "Navi", "Tinker Bell", "Luma" },
                2
            );
            questions.Add(question2);

            // THIRD QUESTION
            Question question3 = new Question(
                "What type of digital media uses the .wav file extension?",
                new List<string>() { "Text", "Audio", "Video", "Image" },
                1
            );
            questions.Add(question3);

            // FOURTH QUESTION
            Question question4 = new Question(
                "In which country is Dracula's castle located in the novel Dracula?",
                new List<string>() { "Austria", "Albania", "England", "Romania" },
                3
            );
            questions.Add(question4);

            // FIFTH QUESTION
            Question question5 = new Question(
                "What is the name of the sword of Arthur Pendragon, the legendary king of Brittany?",
                new List<string>() { "Lancelot", "Excalibur", "Wallace", "Camelot" },
                1
            );
            questions.Add(question5);
        }

        public static bool NextQuestion()
        {
            int nextQuestionIndex = ++currentQuestionIndex;
            if (nextQuestionIndex <= questions.Count - 1)
            {
                currentQuestion = questions[nextQuestionIndex];
                return true;
            }

            return false;
        }
    }
}
