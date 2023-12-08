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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static lab3mp3.Data.MongoCRUD;
using static System.Collections.Specialized.BitVector32;

namespace lab3mp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        jsonHelper js = new jsonHelper();
        Quiz NewQuiz= new Quiz();
        List<Question> NewQuestions = new List<Question>();
        static MongoCrud db = new MongoCrud("quizdb");
        public MainWindow()
        {
            InitializeComponent();
            LoadQuestions();


        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            QuestionWin pg = new QuestionWin();
            pg.ShowDialog();
        }
        public async Task LoadQuestions()
        {
            NewQuestions = await js.LoadQuestions();
            NewQuiz._questions = NewQuestions;
            db.AddQuiz("quiz", NewQuiz);
        }

        private void ChangeQuestion_Click(object sender, RoutedEventArgs e)
        {
            ChangeQuestion question = new ChangeQuestion();
            question.ShowDialog();
        }
    }
}
