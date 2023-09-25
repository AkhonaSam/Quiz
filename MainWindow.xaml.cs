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

namespace Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5 };
        int qNum = 0;
        int i;
        int score;


        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if(senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if(qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;

            NextQuestion();
        }

        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        private void NextQuestion()
        {
            if(qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach(var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkCyan;
            }


            switch (i)
            {
                case 1:
                    txtQuestion.Text = "Which five colours make up the Olympic rings?";

                    ans1.Content = "Red, White, Pink, Black, and Blue";
                    ans2.Content = "Black, Green, Blue, Yellow and Red";
                    ans3.Content = "Black, Violet, Brown, Yellow, and Gold";
                    ans4.Content = "White, Green, Blue, Red, and Black";

                    ans2.Tag = "1";

                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jfif"));

                    break;

                case 2:
                    txtQuestion.Text = "Who painted the Mona Lisa?";

                    ans1.Content = "Leonardo da Vinci";
                    ans2.Content = "Pablo Picasso";
                    ans3.Content = "Michelangelo";
                    ans4.Content = "Claude Monet";

                    ans1.Tag = "1";

                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jfif"));

                    break;

                case 3:
                    txtQuestion.Text = "Which planet is closest to the sun?";

                    ans1.Content = "Earth";
                    ans2.Content = "Jupiter";
                    ans3.Content = "Mercury";
                    ans4.Content = "Neptune";

                    ans3.Tag = "1";

                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jfif"));

                    break;

                case 4:
                    txtQuestion.Text = "What is the largest country in the world?";

                    ans1.Content = "Australia";
                    ans2.Content = "Botswana";
                    ans3.Content = "Ameria";
                    ans4.Content = "Russia";

                    ans4.Tag = "1";

                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jfif"));

                    break;

                case 5:
                    txtQuestion.Text = "What year did South Africa host the Fifa World cup?";

                    ans1.Content = "2010";
                    ans2.Content = "2004";
                    ans3.Content = "2011";
                    ans4.Content = "2022";

                    ans1.Tag = 1;

                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jfif"));

                    break;

            }
        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            questionOrder.Content = null;

            for(int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }

        private void newWinBtn_Click(object sender, RoutedEventArgs e)
        {
            /*NewWindow newWindow = new NewWindow();
            newWindow.Show();

            MainWindow main = new MainWindow();
            main.Close();*/

            this.Hide();
            NewWindow newWindow = new NewWindow();
            newWindow.ShowDialog();
            this.Show();

            /*this.Hide();
SignInWindow signIn = new SignInWindow();
signIn.ShowDialog();
this.Show();
             */
        }
    }
}
