using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalshoots = 0;
            var sphere1 = new Sphere(new Color { Red = 255, Green = 0, Blue = 0 }, 5);
            var sphere2 = new Sphere(new Color { Red = 0, Green = 255, Blue = 0 }, 7);
            var sphere3 = new Sphere(new Color { Red = 0, Green = 0, Blue = 255 }, 6);

            sphere1.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere3.Throw();
            sphere3.Throw();
            sphere3.Throw();
            sphere1.Pop();

            totalshoots += sphere1.GetTimesThrown;
            totalshoots += sphere2.GetTimesThrown;
            totalshoots += sphere3.GetTimesThrown;

            Console.WriteLine(totalshoots);
        }
    }       
}
