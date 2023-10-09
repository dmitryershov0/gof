// See https://aka.ms/new-console-template for more information
using Prototype;

var prototype = new Circle(5, new Point(0, 0));
var cicles = new List<IFigure>();
for (int i = 0; i < 5; i++)
{
    var cirlce = prototype.CloneFigure(new Point(i, i));
    cirlce.GetInfo();
    cicles.Add(cirlce);
}
