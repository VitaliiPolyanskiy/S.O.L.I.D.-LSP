namespace Liskov_Substitution_Principle
{
    public interface IRectangle
    {
       int Width { get; set; }
       int Height { get; set; }
       int GetRectangleArea();
    }
}
