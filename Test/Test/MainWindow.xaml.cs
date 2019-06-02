using QuestionsData;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Test
{
    public partial class MainWindow : Window
    {
        private int time = 15;
        private DispatcherTimer Timer;
        private String[] Questions;
        public Question[] questions;
        public int questionNum = 0, rightAnswers = 0, currentAnswer = 0;

        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            questions = setQuestions().ToArray();
        }

        public List<Question> setQuestions()
        {
            String[] answersQuestion1 = { "a) right", "b) wrong", "c) wrong", "d) wrong" };
            String[] answersQuestion2 = { "a) wrong", "b) right", "c) wrong", "d) wrong" };
            String[] answersQuestion3 = { "a) right", "b) wrong", "c) right", "d) wrong" };
            String[] answersQuestion4 = { "a) wrong", "b) wrong", "c) wrong", "d) right" };
            String[] answersQuestion5 = { "a) right", "b) wrong", "c) wrong", "d) wrong" };
            List<Question> questions = new List<Question>();
            questions.Add(new Question("Question1 is here?", answersQuestion1, "right"));
            questions.Add(new Question("Question2 is here?", answersQuestion2, "right"));
            questions.Add(new Question("Question3 is here?", answersQuestion3, "right"));
            questions.Add(new Question("Question4 is here?", answersQuestion4, "right"));
            questions.Add(new Question("Question5 is here?", answersQuestion5, "right"));
            return questions;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (time>0)
            {
                if (time <=10)
                {
                    if (time%2==0)
                    {
                        TBCountDown.Foreground = Brushes.Red;
                    }
                    else
                    {
                        TBCountDown.Foreground = Brushes.Black;
                    }
                    time--;
                    TBCountDown.Text = string.Format("00:0{0}:0{1}", time / 60, time % 60);
                }
                else
                {
                    time--;
                    TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
                }
            }
            else
            {
                Timer.Stop();
                MessageBox.Show("Time is up!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
            showQuestionAndAnswers();
        }

        public Question getQuestion(Question[] questions, int i) {
            return questions[i];
        }

        private void QuestionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void AnswersTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (questionNum==0)
            {
                MessageBox.Show("Timer IS NOT started! Please Start the timer FIRST!");
            }
            else
            {
                showQuestionAndAnswers();
            }
            if (questionNum >= questions.Length)
            {
                Timer.Stop();
                MessageBox.Show("You finnished the test.\n IN Bulgaria after every test we say: \n " +
                    "\" Day boje troyka \"  SO... \n Day boje troyka \n After clicking \" OK \" you can start the test again.");
                questionNum = 0;
                time = 15;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            currentAnswer = 2;
            string answer = getQuestion(questions, questionNum - 1).Answers[1];
            Answer.Text = answer;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentAnswer = 3;
            string answer = getQuestion(questions, questionNum - 1).Answers[2];
            Answer.Text = answer;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            currentAnswer = 4;
            string answer = getQuestion(questions, questionNum - 1).Answers[3];
            Answer.Text = answer;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currentAnswer = 1;
            string answer = getQuestion(questions, questionNum - 1).Answers[0];
            Answer.Text = answer;
        }

        private void showQuestionAndAnswers()
        {
            QuestionTextBox.Text = getQuestion(questions, questionNum).QuestionTitle;
            String answers = "";
            for (int i = 0; i < getQuestion(questions, questionNum).Answers.Length; i++)
            {
                answers += getQuestion(questions, questionNum).Answers[i];
                answers += "\n";
            }

            AnswersTextBox.Text = answers;

            questionNum++;
        }

    }
}
