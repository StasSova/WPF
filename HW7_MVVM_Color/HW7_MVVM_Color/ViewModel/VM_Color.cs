using HW7_MVVM_Color.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HW7_MVVM_Color.ViewModel
{
    public class VM_Color : VM_Base, IEquatable<VM_Color>
    {
        public VM_Color()
        {
            A = 255;
            R = 255;
            G = 255;
            B = 255;
        }
        public VM_Color Clone()
        {
            return new VM_Color
            {
                A = this.A,
                R = this.R,
                G = this.G,
                B = this.B,
            };
        }

        private M_Color color;
        public string Name
        {
            get { return color.Name; }
            set 
            { 
                color.Name = value; 
                OnPropertyChanged(nameof(Name));
            }
        }

        private int a;
        public int A
        {
            get { return a; }
            set
            {
                a = value;
                OnPropertyChanged(nameof(A));
                UpdateColor();
            }
        }
        private int r;
        public int R
        {
            get { return r; }
            set
            {
                r = value;
                OnPropertyChanged(nameof(R));
                UpdateColor();
            }
        }
        private int g;
        public int G
        {
            get { return g; }
            set
            {
                g = value;
                OnPropertyChanged(nameof(G));
                UpdateColor();
            }
        }
        private int b;
        public int B
        {
            get { return b; }
            set
            {
                b = value;
                OnPropertyChanged(nameof(B));
                UpdateColor();
            }
        }
        private void UpdateColor()
        {
            if (color == null) { color = new M_Color(" "); }
            Name = Color.FromArgb((byte)A, (byte)R, (byte)G, (byte)B).ToString();
        }


        public bool Equals(VM_Color other)
        {
            if (other is null)
                return false;

            return A == other.A && R == other.R && G == other.G && B == other.B;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as VM_Color);
        }

        public override int GetHashCode()
        {
            return (A, R, G, B).GetHashCode();
        }

    }
}
