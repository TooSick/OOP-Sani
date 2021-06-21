using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Redo
    {
        private Stack<Shape> FiguresSt;
        public Redo()
        {
            FiguresSt = new Stack<Shape>();
        }

        public void Push(Shape figures)
        {
            FiguresSt.Push(figures);
        }

        public Shape Pop()
        {
            return FiguresSt.Pop();
        }

        public void ClearSt()
        {
            FiguresSt.Clear();
        }

        public bool Blank()
        {
            if (FiguresSt.Count == 0)
                return false;

            return true;
        }
    }
}
