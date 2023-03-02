namespace Learning05
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius, string color) : base(color, "circle")
        {
            this._radius = radius;            
        }


        public override double GetArea()
        {
            return MathF.PI * (this._radius * this._radius);
        }
    }
}