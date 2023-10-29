namespace Generic_Classes
{
    public class TestConstrains
    {
        interface IShape {}

        interface IRectangle {}

        class Square : IShape {}

        interface IFourSidedShape : IShape {}

        class Rectangle  : IFourSidedShape {}

        class SmallRectangle :  IRectangle {
            public int _length { get; set; }
            public int _width { get; set; }
            public SmallRectangle(int length, int width)
            {
                this._length = length;
                this._width = width;
            }
        }

        class BigRectangle : IRectangle {}
        class ConstrainByCombination<T> where T : IRectangle, new () { } // new () { } means it should have public parameter less constructor

        public static void Main(string[] args) 
        {
            new ConstrainByCombination<BigRectangle>(); // Valid
            // new ConstrainByCombination<SmallRectangle>(); // Invalid
            Console.WriteLine("Hack the World!");
        }
    }
}

// See https://aka.ms/new-console-template for more information
