﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;

namespace OOP
{
    [DataContract]
    public class Undo
    {
        [DataMember]
        private List<Shape> FiguresList;
        public void Add(Shape figures)
        {
            FiguresList.Add(figures);
        }

        public void draw(Graphics graphics)
        {
            foreach (var figures in FiguresList)
            {
                figures.Drawing(graphics);
            }
        }

        public Undo()
        {
            FiguresList = new List<Shape>();
        }

        public Shape Delete()
        {
            Shape temp = FiguresList.Last();
            FiguresList.Remove(FiguresList.Last());
            return temp;
        }

        public bool IsEmpty()
        {
            if (FiguresList.Count == 0)
                return false;

            return true;
        }

    }
}
