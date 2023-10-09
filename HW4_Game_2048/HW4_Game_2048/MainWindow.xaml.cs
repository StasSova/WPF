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

namespace HW4_Game_2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock[,] board;
        Game game;
        bool EnableKeyInput = true;
        int MaxScore = 0;
        public MainWindow()
        {
            InitializeComponent();
            game = new Game();
            board = new TextBlock[4, 4];
            #region INIT BOARD
            board[0,0] = txt00;
            board[0,1] = txt01;
            board[0,2] = txt02;
            board[0,3] = txt03;

            board[1,0] = txt10;
            board[1,1] = txt11;
            board[1,2] = txt12;
            board[1,3] = txt13;

            board[2,0] = txt20;
            board[2,1] = txt21;
            board[2,2] = txt22;
            board[2,3] = txt23;

            board[3,0] = txt30;
            board[3,1] = txt31;
            board[3,2] = txt32;
            board[3,3] = txt33;
            #endregion INIT BOARD
        }
        private void NewGame()
        {
            // очищаем доску
            game.ClearBoard();
            // вставляем случайное значение в случайную ячейку
            game.PutNewValue();
            // запускаем чтения клавиш
            EnableKeyInput = false;
            // Аналируем кол-во очков
            NumScore.Text = "0";
            // синхронизируем ячейки 
            Update();
        }
        private void Update()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col].Text = game[row, col] == 0
                        ? string.Empty
                        : game[row, col].ToString();
                }
            }
            NumScore.Text = game.Score.ToString();

            if (Convert.ToInt64(NumHighScore.Text) < game.Score)
                NumHighScore.Text = NumScore.Text;

        }
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (EnableKeyInput)
                e.Handled = true;
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            bool IsUpdate = false;
            switch (e.Key)
            {
                case (Key.Up):
                    IsUpdate = game.Update(Direction.Up);
                    break;
                case (Key.Down):
                    IsUpdate = game.Update(Direction.Down);
                    break;
                case (Key.Left):
                    IsUpdate = game.Update(Direction.Left);
                    break;
                case (Key.Right):
                    IsUpdate = game.Update(Direction.Right);
                    break;
            }
            if (IsUpdate)
            {
                game.PutNewValue();
                Update();

                if (game.IsEnd())
                {
                    MessageBoxResult res =
                    MessageBox.Show("Ходы закончились\nНачнем сначала", "End...", MessageBoxButton.YesNo);

                    if (res == MessageBoxResult.Yes)
                        NewGame();
                    else EnableKeyInput = true;
                }
            }
        }
    }
}
