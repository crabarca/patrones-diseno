using System.Transactions;

namespace Prototype
{
    public class Color: IPrototype<Color>
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public Color Clone()
        {
            return new Color(Red, Green, Blue);
        }
    }
}