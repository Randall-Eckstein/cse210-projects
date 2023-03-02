namespace Learning05
{
    public abstract class Shape
    {
        private string _color;
        private string _shape;

        public Shape(string color, string shape)
        {
            this._color = color.ToLower();
            this._shape = shape;
        }

        public void SetColor(string color)
        {
            this._color = color;
        }

        public string GetColor()
        {
            return this._color;
        }

        public string GetShape()
        {
            return this._shape;
        }

        public abstract double GetArea();
    }
}