using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Controls_NumbersGame
{
    class Game
    {
        // Numbers that will be displayed on the buttons
        public int[] Numbers { get; set; }
        // Number of digits
        public int Quantity { get; set; }
        // Current position on array
        private int CurrentPos;
        public Game() 
        {
            Quantity = 16;
            CurrentPos = 0;
            Numbers = new int[Quantity];
        }
        public void ResetPosition() => CurrentPos = 0;
        public int GetPosition() { return CurrentPos; } 
        public void InitNumbers()
        {
            Random r = new Random();
            int n;
            for (int i = 0; i< Quantity;) 
            {
                n = r.Next(0,100);
                if (!Numbers.Contains(n))
                {
                    Numbers[i] = n;
                    i++;
                }    
            }
        }
        public void SortNumbers()
        {
            Array.Sort(Numbers);
        }
        public bool Check(int select)
        {
            if (select == Numbers[CurrentPos])
            {
                CurrentPos++;
                return true; 
            }
            return false;
        }
        public bool IsFinish()
        {
            return CurrentPos == Quantity;
        }
    }
}
