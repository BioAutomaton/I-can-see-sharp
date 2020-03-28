using System;

namespace Lab2
{
    public class Rectangle : Quadrangle
    {
        public Rectangle(int seed) : base(seed)
        {

        }

        public bool IsRectangle()
        {
            bool result = false;
            if (diagonal[0] == diagonal[1])
            {
                if (length[0] == length[2] && length[1] == length[3])
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
