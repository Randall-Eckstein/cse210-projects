namespace Learning05
{
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width, string color) : base(color, "rectangle")
        {
            this._length = length;
            this._width = width;
        }

        public override double GetArea()
        {
            return this._length * this._width;
        }
    }
}