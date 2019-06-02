using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionsData
{
    public class Question
    {
        public String QuestionTitle { get; set; }
        public String[] Answers { get; set; }
        public String RightAnswer { get; set; }

        public Question(String QuestionTitle, String[] Answers, String RightAnswer)
        {
            this.Answers = Answers;
            this.QuestionTitle = QuestionTitle;
            this.RightAnswer = RightAnswer;
        }
    }
}
