namespace DataStructures.Models;

public class ScreenSize 
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double H_Center => Width / 2;
    public double V_Center => Height / 2;
}