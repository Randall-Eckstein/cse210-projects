namespace Learning05
{
    public class Square : Shape
    {
        private double _side;

        public Square(double side, string color) : base(color, "square")
        {
            this._side = side;
        }

        public override double GetArea()
        {
            return this._side * this._side;
        }
    }
}