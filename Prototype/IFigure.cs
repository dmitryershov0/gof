namespace Prototype;

public interface IFigure
{
    public int X { get; }
    public int Y { get; }
    IFigure CloneFigure(Point point);
    void GetInfo();
}
