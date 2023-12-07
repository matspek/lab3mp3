using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab3mp3
{
    /// <summary>
    /// Interaction logic for QuestionWin.xaml
    /// </summary>
    public partial class QuestionWin : Window
    {
        Question newquestion1 = new Question();
        jsonHelper js = new jsonHelper();
        Quiz NewQuiz = new Quiz();
        List<Question> NewQuestions = new List<Question>();
        int correctAwser;
        int nummersofwin=0;
        int nrCorrrectAwnsers = 0;
        public QuestionWin()
        {
            InitializeComponent();
            LoadQuestions();


        }
        private void awnser1_Click(object sender, RoutedEventArgs e)
        {
            if (NewQuiz._questions[0].CorrectAnswer == 1)
            {
                MessageBox.Show("Correct awnser");
                nrCorrrectAwnsers++;


            }
            nextquestion();


        }

        private void awnser2_Click(object sender, RoutedEventArgs e)
        {
            if (correctAwser == 2)
            {
                MessageBox.Show("Correct awnser");
                nrCorrrectAwnsers++;


            }
            nextquestion();
        }

        private void awnser3_Click(object sender, RoutedEventArgs e)
        {
            if (correctAwser == 3)
            {
                MessageBox.Show("Correct awnser");
                nrCorrrectAwnsers++;

            }
            nextquestion();

        }

        private void awnser4_Click(object sender, RoutedEventArgs e)
        {
            if (correctAwser == 4)
            {
                MessageBox.Show("Correct awnser");
                nrCorrrectAwnsers++;
            }
            nextquestion();
        }
        public async Task LoadQuestions()
        {
            NewQuestions = await js.LoadQuestions();
            NewQuiz._questions = NewQuestions;
        
            
                statment.Text = NewQuiz._questions[0].Statement;
                awnser1.Content = NewQuiz._questions[0].Answers[0];
                awnser2.Content = NewQuiz._questions[0].Answers[1];
                awnser3.Content = NewQuiz._questions[0].Answers[2];
                awnser4.Content = NewQuiz._questions[0].Answers[3];
                correctAwser = NewQuiz._questions[0].CorrectAnswer;

            
        }
        public void nextquestion()
        {
            nummersofwin++;
            if (nummersofwin < NewQuiz._questions.Count)
            {

                statment.Text = NewQuiz._questions[nummersofwin].Statement;
                awnser1.Content = NewQuiz._questions[nummersofwin].Answers[0];
                awnser2.Content = NewQuiz._questions[nummersofwin].Answers[1];
                awnser3.Content = NewQuiz._questions[nummersofwin].Answers[2];
                awnser4.Content = NewQuiz._questions[nummersofwin].Answers[3];
                correctAwser = NewQuiz._questions[nummersofwin].CorrectAnswer;
            }
            else 
            { 
                Close();
                double Nrqustions = (double)NewQuiz._questions.Count;
                double result = (nrCorrrectAwnsers / Nrqustions)*100;
                MessageBox.Show(string.Concat(result)+ " %");
            }
        }
    }

}