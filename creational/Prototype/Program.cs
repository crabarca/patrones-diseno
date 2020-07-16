using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var color1 = new Color(0, 0, 255);
            var color2 = color1.Clone();
        }
    }
}