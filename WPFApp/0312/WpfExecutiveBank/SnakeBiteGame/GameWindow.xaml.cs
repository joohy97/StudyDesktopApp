using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace SnakeBiteGame
{
    /// <summary>
    /// GameWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GameWindow : Window
    {
        Random rand = new Random();

        Ellipse[] snake = new Ellipse[30];
        Ellipse egg = new Ellipse();
        private int size = 12;
        private int visibleCount = 5;
        private string move = "";
        private int eaten = 0;
        DispatcherTimer playTimer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        private bool startFlag = false;

            

        public GameWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            intitSnake();
            initEgg();

            playTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            playTimer.Tick += playTimer_Tick;
            playTimer.Start();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void initEgg()
        {
            throw new NotImplementedException();
        }

        private void intitSnake()
        {
            //뱀이 생성되는 위치
            int x = rand.Next(1, 500 / size) * size;
            int y = rand.Next(1, 400 / size) * size;

            for (int i = 0; i < snake.Length; i++)
            {
                snake[i] = new Ellipse();
                snake[i].Width = snake[i].Height = size;
                if (i == 0)
                    snake[i].Fill = Brushes.Chocolate;
                else if (i % 5 == 0)
                    snake[i].Fill = Brushes.YellowGreen;
                else
                    snake[i].Fill = Brushes.Gold;
                snake[i].Stroke = Brushes.Black;

                CvsGame.Children.Add(snake[i]);
            }
            
            //뱀길이를 5개로 나오게 하고 나머지는 지우기
            for (int i = visibleCount; i < snake.Length; i++)
            {
                snake[i].Visibility = Visibility.Hidden;
            }

            CreateSnake(x, y);

        }

        private void CreateSnake(int x, int y)
        {
            for (int i = 0; i < visibleCount; i++)
            {
                snake[i].Tag = new Point(x, y + i * size);
                Canvas.SetLeft(snake[i], x);
                Canvas.SetTop(snake[i], y + i * size);
            }
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
