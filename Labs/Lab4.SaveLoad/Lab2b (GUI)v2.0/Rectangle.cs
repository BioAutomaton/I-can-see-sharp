using System;

namespace Lab2b__GUI_
{
    public class Rectangle : Quadrangle
    {
        public Rectangle(int seed) : base(seed)
        {

        }

        public bool IsRectangle()
        {
            bool result = false;
            if (Diagonal[0] == Diagonal[1])
            {
                if (Length[0] == Length[2] && Length[1] == Length[3] && Length[0] > 4)
                {
                    if (Diagonal[0] > Length[0] && Diagonal[0] > Length[1])
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}


