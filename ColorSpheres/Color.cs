using System;

namespace ColorSpheres
{
    public class Color
    {
        private int Red;
        private int Green;
        private int Blue;
        private int Alpha;

        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }
        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }   
    }    
}