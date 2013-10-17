namespace SolidPrinciples.Demo.OCP
{
    public class Product
    {
        public Product(ProductColor color)
        {
            this.Color = color;
        }

        public ProductColor Color { get; set; }

        public ProductSize Size { get; set; }
    }

    public enum ProductColor
    {
        Blue,
        Yellow,
        Red,
        Gold,
        Brown
    }

    public enum ProductSize
    {
        Small, Medium, Large, ReallyBig
    }

   
}
