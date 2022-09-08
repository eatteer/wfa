using System.Collections.Generic;
using WFA.Models;

namespace WFA
{
    class GameManager
    {
        public static List<Question> questions = new List<Question>();
        public static Question currentQuestion;
        private static int currentQuestionIndex = 0;

        public static void InitGame()
        {
            // FIRST QUESTION
            Question question1 = new Question(
                "¿Cómo se llama el payaso en la película IT?",
                new List<string>() { "Pennywise", "Joker", "Krusty", "Spaulding" },
                0
            );
            questions.Add(question1);
            currentQuestion = question1;

            // SECOND QUESTION
            Question question2 = new Question(
                "¿Cómo se llama el hada de la película de Disney Peter Pan?",
                new List<string>() { "Wendy", "Navi", "Campanilla", "Luma" },
                2
            );
            questions.Add(question2);

            // THIRD QUESTION
            Question question3 = new Question(
                "¿Qué tipo de medio digital usa la extensión de archivo .wav?",
                new List<string>() { "Texto", "Audio", "Video", "Imagen" },
                1
            );
            questions.Add(question3);

            // FOURTH QUESTION
            Question question4 = new Question(
                "¿En cuál país se encuentra el castillo de Drácula en la novela Drácula?",
                new List<string>() { "Austria", "Albania", "Inglaterra", "Rumanía" },
                3
            );
            questions.Add(question4);

            // FIFTH QUESTION
            Question question5 = new Question(
                "¿Cómo se llama la espada de Arthur Pendragon, el legendario rey de Bretaña?",
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
