using System.Collections.Generic;

namespace WFA.Models
{
    class Question
    {
        public string question;
        public List<string> answers;
        public int correntAnswerIndex;

        public Question(string question, List<string> answers, int correctAnswerIndex)
        {
            this.question = question;
            this.answers = answers;
            this.correntAnswerIndex = correctAnswerIndex;
        }
    }
}
