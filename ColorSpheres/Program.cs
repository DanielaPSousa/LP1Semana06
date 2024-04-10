using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color(255, 0, 0);
            Color blue = new Color(0, 0, 255);
            Sphere smallSphere = new Sphere(red, 5);
            Sphere largeSphere = new Sphere(blue, 10);

            smallSphere.Throw();
            largeSphere.Throw();

            Console.WriteLine($"Small sphere: color={smallSphere.color.GetGrey()}, radius={smallSphere.Radius}, times thrown={smallSphere.thrown}");
            Console.WriteLine($"Large sphere: color={largeSphere.color.GetGrey()}, radius={largeSphere.Radius}, times thrown={largeSphere.thrown}");

            smallSphere.Pop();

            Console.WriteLine($"Small sphere: color={smallSphere.color.GetGrey()}, radius={smallSphere.Radius}, times thrown={smallSphere.thrown}");
            Console.WriteLine($"Large sphere: color={largeSphere.color.GetGrey()}, radius={largeSphere.Radius}, times thrown={largeSphere.thrown}");
        }
    }
}
