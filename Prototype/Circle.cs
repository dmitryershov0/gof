namespace Prototype
{
    public record Circle : Point, IFigure
    {
        private int _radius { get; init; }
        public Circle(int radius, Point point) : base(point)
        {
            _radius = radius;
        }

        public IFigure CloneFigure(Point point)
        {
            var (X, Y) = point;
            return this with { X = X, Y = Y };
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", _radius, X, Y);
        }
    }
}
