using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionsData
{
    public class QuestionService
    {

        public List<Question> allQuestions {
            get
            {
                return setQuestions();
            }
        }
        public List<Question> setQuestions() {
            String[] answersQuestion1 = { "a) wrong", "b) wrong", "c) right", "d) wrong" };
            String[] answersQuestion2 = { "a) wrong", "b) wrong", "c) right", "d) wrong" };
            String[] answersQuestion3 = { "a) wrong", "b) wrong", "c) right", "d) wrong" };
            String[] answersQuestion4 = { "a) wrong", "b) wrong", "c) right", "d) wrong" };
            String[] answersQuestion5 = { "a) wrong", "b) wrong", "c) right", "d) wrong" };
            List<Question> questions = null;
            questions.Add(new Question("Question1 is here?", answersQuestion1, "right"));
            questions.Add(new Question("Question2 is here?", answersQuestion2, "right"));
            questions.Add(new Question("Question3 is here?", answersQuestion3, "right"));
            questions.Add(new Question("Question4 is here?", answersQuestion4, "right"));
            questions.Add(new Question("Question5 is here?", answersQuestion5, "right"));
            return questions;
        }
    }
}
