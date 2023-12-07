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
    /// Interaction logic for ChangeQuestion.xaml
    /// </summary>
    public partial class ChangeQuestion : Window
    {
        jsonHelper js = new jsonHelper();
        Quiz NewQuiz = new Quiz();
        List<Question> NewQuestions = new List<Question>();
        public ChangeQuestion()
        {
            InitializeComponent();
            LoadQuestions();

        }
        
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Question q1 = new Question();
            q1.Statement = Question1.Text;
            q1.Answers[0] = Awnser1.Text;
            q1.Answers[1] = Awnser2.Text;
            q1.Answers[2] = Awnser3.Text;
            q1.Answers[3]= Awnser4.Text;
            if (awnser1Corrent.IsChecked==true)
            {
                q1.CorrectAnswer = 0;
            } else if (awnser2Corrent.IsChecked == true)
            {
                q1.CorrectAnswer = 1;
            } else if (awnser3Corrent.IsChecked == true)
            {
                q1.CorrectAnswer = 2;
            } else if (awnser4Corrent.IsChecked == true)
                {
                q1.CorrectAnswer = 3;
            }else
            {
                MessageBox.Show("No correct awnser selected");

            }
            
            NewQuiz._questions.Add(q1);
            js.SaveQuestions(NewQuiz._questions);
            Close();    
        }
        public async Task LoadQuestions()
        {
            NewQuestions = await js.LoadQuestions();
            NewQuiz._questions = NewQuestions;
        }
    }
    }

