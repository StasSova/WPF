using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Game_2048
{
    public enum Direction { Up, Down, Left, Right }
    internal class Game
    {
        private int[,] board;
        public int Score { get; set; }
        private List<KeyValuePair<int, int>> probability;

        private Random random = new Random();
        public Game() 
        {
            board = new int[4,4];
            Score = 0;
            probability = new List<KeyValuePair<int, int>>();
            probability.Add(new KeyValuePair<int, int>(2, 90));
            probability.Add(new KeyValuePair<int, int>(4, 10));
        }
        public void ClearBoard()
        {
            for (int r = 0; r < board.GetLength(0);r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                    board[r, c] = 0;
            }
            Score = 0;
        }
        private int GetRandomNumber()
        {
            // получаем случайное значения 
            int value = random.Next(0, 100);

            // накопленная вероятность 
            int sumProb = 0;

            // для каждой вероятности 
            foreach (var b in probability)
            {
                // добавляем вероятность значения 
                sumProb += b.Value;
                // и если она больше, возвращаем ключ 
                if (value <= sumProb)
                    return b.Key;
            }

            // По умолчанию, если что-то пошло не так
            return 0; 
        }
        public void PutNewValue()
        {
            List<Tuple<int,int>> empty = new List<Tuple<int,int>>();
            // ищем пустые клетки
            for (int iRow = 0; iRow < board.GetLength(0); iRow++)
            {
                for (int iCol = 0;iCol < board.GetLength(1); iCol++)
                {
                    // если пустая, добавляем координаты, этой пустой ячейки
                    if (board[iRow, iCol] == 0)
                        empty.Add(new Tuple<int, int>(iRow, iCol));
                }
            }
            if (empty.Count == 0) return;

            // далее мы выбираем случайный слот 
            int slot = random.Next(0, empty.Count);
            // в него мы помещаем случайное число
            board[empty[slot].Item1, empty[slot].Item2] = GetRandomNumber();
        }
        private bool BoardIsFull()
        {
            foreach (int item in board)
            {
                if (item == 0)
                    return false;
            }
            return true;
        }
        private bool CanMove(int[,] currentBoard)
        {
            // проверяем строки
            for (int row = 0; row < currentBoard.GetLength(0); row++)
            {
                for (int col = 0; col < currentBoard.GetLength(1) - 1; col++)
                {
                    if (currentBoard[row, col] == currentBoard[row, col + 1])
                    {
                        return true; // Есть возможные ходы
                    }
                }
            }
            // проверяем столбцы 
            for (int col = 0; col < currentBoard.GetLength(1); col++)
            {
                for (int row = 0; row < currentBoard.GetLength(0) - 1; row++)
                {
                    if (currentBoard[row, col] == currentBoard[row + 1, col])
                    {
                        return true; // Есть возможные ходы
                    }
                }
            }

            return false; // Нет возможных ходов
        }

        public bool IsEnd()
        {
            if (BoardIsFull() && !CanMove(board))
            {
                // Доска полная и нет возможных ходов, игра проиграна
                return true;
            }

            return false;
        }
        private bool UpdateUp(int[,] board)
        {
            bool IsUpdate = false;

            // проходимся по каждому столбцу 
            for (int col = 0; col < board.GetLength(1); col++)
            {
                // каждой строке 
                for (int row = 1; row < board.GetLength(0); row++)
                {
                    // если на доске елемент имеет значение (не пуст)
                    if (board[row, col] != 0)
                    {
                        int currentRow = row;
                        // если верхний елемент 0 и текущая строка больше 0
                        while (currentRow > 0 && board[currentRow - 1, col] == 0)
                        {
                            // Сдвигаем вверх
                            board[currentRow - 1, col] = board[currentRow, col];
                            board[currentRow, col] = 0;
                            currentRow--;
                            IsUpdate = true;
                        }

                        // если текущая строка больше 0 и верхняя такая же 
                        if (currentRow > 0 && board[currentRow - 1, col] == board[currentRow, col] && board[currentRow, col] != 0)
                        {
                            // Объединяем числа
                            board[currentRow - 1, col] *= 2;
                            board[currentRow, col] = 0;
                            Score += board[currentRow - 1, col];
                            IsUpdate = true;
                        }
                    }
                }
            }

            return IsUpdate;
        }
        private bool UpdateDown(int[,] board)
        {
            bool IsUpdate = false;

            // проходимся по каждому столбцу 
            for (int col = 0; col < board.GetLength(1); col++)
            {
                // каждой строке, начиная с предпоследнего элемента столбца
                for (int row = board.GetLength(0) - 2; row >= 0; row--)
                {
                    // если ячейка пуска 
                    if (board[row, col] != 0)
                    {
                        int currentRow = row;
                        // текущая позиция не последняя в столбце и нижняя за нее пустая
                        while (currentRow < board.GetLength(0) - 1 && board[currentRow + 1, col] == 0)
                        {
                            // Сдвигаем вниз
                            board[currentRow + 1, col] = board[currentRow, col];
                            board[currentRow, col] = 0;
                            currentRow++;
                            IsUpdate = true;
                        }
                        // текущая позиция не последняя и ниже такой же самый блок , кроме пустого
                        if (currentRow < board.GetLength(0) - 1 && board[currentRow + 1, col] == board[currentRow, col] && board[currentRow,col] != 0)
                        {
                            // Объединяем числа
                            board[currentRow + 1, col] *= 2;
                            board[currentRow, col] = 0;
                            Score += board[currentRow + 1, col];
                            IsUpdate = true;
                        }
                    }
                }
            }

            return IsUpdate;
        }
        private bool UpdateLeft(int[,] board)
        {
            bool isUpdate = false;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 1; col < board.GetLength(1); col++)
                {
                    if (board[row, col] != 0)
                    {
                        int currentCol = col;
                        while (currentCol > 0 && board[row, currentCol - 1] == 0)
                        {
                            // Сдвигаем влево
                            board[row, currentCol - 1] = board[row, currentCol];
                            board[row, currentCol] = 0;
                            currentCol--;
                            isUpdate = true;
                        }

                        if (currentCol > 0 && board[row, currentCol - 1] == board[row, currentCol])
                        {
                            // Объединяем числа
                            board[row, currentCol - 1] *= 2;
                            board[row, currentCol] = 0;
                            Score += board[row, currentCol - 1];
                            isUpdate = true;
                        }
                    }
                }
            }

            return isUpdate;
        }
        private bool UpdateRight(int[,] board)
        {
            bool isUpdate = false;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = board.GetLength(1) - 2; col >= 0; col--)
                {
                    if (board[row, col] != 0)
                    {
                        int currentCol = col;

                        while (currentCol < board.GetLength(1) - 1 && board[row, currentCol + 1] == 0)
                        {
                            // Сдвигаем вправо
                            board[row, currentCol + 1] = board[row, currentCol];
                            board[row, currentCol] = 0;
                            currentCol++;
                            isUpdate = true;
                        }

                        if (currentCol < board.GetLength(1) - 1 && board[row, currentCol + 1] == board[row, currentCol] && board[row, currentCol + 1] != 0)
                        {
                            // Объединяем числа
                            board[row, currentCol + 1] *= 2;
                            board[row, currentCol] = 0;
                            Score += board[row, currentCol + 1];
                            isUpdate = true;
                        }
                    }
                }
            }

            return isUpdate;
        }
        public bool Update(Direction direction)
        {
            bool isUpdate = false;
            // Вызываем соответствующий метод в зависимости от направления
            switch (direction)
            {
                case Direction.Up:
                    isUpdate = UpdateUp(board);
                    break;

                case Direction.Down:
                    isUpdate = UpdateDown(board);
                    break;

                case Direction.Left:
                    isUpdate = UpdateLeft(board);
                    break;

                case Direction.Right:
                    isUpdate = UpdateRight(board);
                    break;
            }
            return isUpdate;
        }

        public int this[int row, int column]
        {
            get
            {
                if (row >= 0 && row < board.GetLength(0) &&
                    column >= 0 && column < board.GetLength(1))
                    return board[row, column];
                return -1;
            }
        }
    }
}
