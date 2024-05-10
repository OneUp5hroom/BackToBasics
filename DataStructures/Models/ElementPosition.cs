namespace DataStructures.Models;

public class ElementPostion
{
    public double Top { get; set; }
    public double Left { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double H_Center => Left + Width / 2;
    public double V_Center => Top + Height / 2;

    public ElementPostion(){ }
    public ElementPostion(double top, double left)
    {
        Top = top;
        Left = left;
        Width = 50;
        Height = 50;
    }

}