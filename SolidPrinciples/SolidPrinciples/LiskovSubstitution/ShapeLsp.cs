using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SolidPrinciples.LiskovSubstitution
{
    public class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
  
        public double GetArea()
        {
            return Width * Height;
        }
  
        public void ChangeDimensions(Rectangle rect, double width, double height)
        {
            rect.Width = width;
            rect.Height = height;
            Console.WriteLine($"Area: {rect.GetArea()}");
        }
    }
  
    public class Square : Rectangle
    {
        public override double Width
        {
            get { return base.Width; }
            set { base.Width = base.Height = value; }
        }
  
        public override double Height
        {
            get { return base.Height; }
            set { base.Width = base.Height = value; }
        }
    }
  
    public class Program
    {
        public static void Main()
        {
            var rect = new Rectangle { Width = 2, Height = 3 };
            rect.ChangeDimensions(rect, 4, 5);  // This works fine
  
            var square = new Square { Width = 2 };
            rect.ChangeDimensions(square, 4, 5);  // This behaves unexpectedly!
  
            Console.ReadKey();
        }
    }
  
}
