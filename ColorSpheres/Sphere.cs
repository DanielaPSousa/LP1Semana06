using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color Color;
        private float Radius;
        private int thrown;

        public Sphere(Color color, int radius)
        {
            this.Color = color;
            this.Radius = radius;
            this.thrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }
        public float GetRaio()
        {
            return Radius;
        }

        public void Throw()
        {
            thrown++;
        }
        public int GetTimesThrown()
        {
            return thrown;
        }
    }
}