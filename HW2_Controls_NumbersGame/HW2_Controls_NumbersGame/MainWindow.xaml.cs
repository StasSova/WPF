using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace HW2_Controls_NumbersGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List of buttons, that location on main window 
        List<Button> buttons = new List<Button>();
        Game game;
        int TimeForGame;
        DispatcherTimer timer;
        TimeSpan timeSpan;
        public MainWindow()
        {
            InitializeComponent();
            
            // Timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += TimerTick;

            // Other
            game = new Game();
            TimeForGame = 60; // default value in second
            progressBar.Maximum = TimeForGame;
            progressBar.Minimum = 0;
            #region Initializing a list of buttons
            buttons.Add(btn00);
            buttons.Add(btn01);
            buttons.Add(btn02);
            buttons.Add(btn03);
            buttons.Add(btn10);
            buttons.Add(btn11);
            buttons.Add(btn12);
            buttons.Add(btn13);
            buttons.Add(btn20);
            buttons.Add(btn21);
            buttons.Add(btn22);
            buttons.Add(btn23);
            buttons.Add(btn30);
            buttons.Add(btn31);
            buttons.Add(btn32);
            buttons.Add(btn33);
            #endregion

            NewGame();
        }
        private void InitNumbers()
        {
            game.InitNumbers();
            for (int i = 0; i < buttons.Count; i++) 
            {
                buttons[i].Content = game.Numbers[i];
            }
            game.SortNumbers();
        }
        private void HideAndDisableNumbers()
        {
            foreach (var button in buttons)
            {
                button.IsEnabled = false;
                button.Content = "?";
            }
        }
        private void EnableNumbers() 
        {
            foreach (var button in buttons)
            {
                button.IsEnabled = true;
            }
        }
        private void ResetStyleNumbers()
        {
            foreach(var button in buttons)
            {
                button.Style = (Style)FindResource("ButtonForNumber");
            }
        }
        private void TimeIsOver()
        {
            HideAndDisableNumbers();
            MessageBox.Show("You lose", "Finish", MessageBoxButton.OK);
        }
        private void TimerTick(object sender, EventArgs e)
        {
            if (progressBar.Minimum >= progressBar.Value)
            {
                TimeIsOver();
                timer.Stop();
                return;
            }
            progressBar.Value -= 1;
            timeSpan = TimeSpan.FromSeconds(progressBar.Value);
            textBlockTime.Text = $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
        }
        private void NewGame()
        {
            timer.Stop();
            timeSpan = TimeSpan.FromSeconds(TimeForGame);
            textBlockTime.Text = $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
            EnableNumbers();
            ResetStyleNumbers();
            InitNumbers();
            progressBar.Value = TimeForGame;
            txtBox.Text = string.Empty;
            timer.Start();
        }
        private void btn_Restart_Click(object sender, RoutedEventArgs e)
        {
           NewGame();
        }
        public void AddNumberToList(int number)
        {
            txtBox.Text += $"{number} ";
        }
        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement el = e.OriginalSource as FrameworkElement;
            if (el is Button btn)
            {
                try
                {
                    int number = Convert.ToInt32(btn.Content);
                    // Проверяем число на кнопке идет в своей очереди или нет
                    if (game.Check(number))
                    {
                        AddNumberToList(number);
                    
                        btn.IsEnabled = false;
                        btn.Style = (Style)FindResource("ButtonForNumberDisable");
                        
                        if (game.IsFinish())
                        {
                            timer.Stop();
                            MessageBox.Show("You win","Finish",MessageBoxButton.OK);
                            return;
                        }
                    }
                    else
                    {
                        progressBar.Value -= TimeForGame / 10;
                        timeSpan = TimeSpan.FromSeconds(progressBar.Value);
                        textBlockTime.Text = $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
                    }
                }
                catch (Exception ex) { }
            }
        }
    }
}
