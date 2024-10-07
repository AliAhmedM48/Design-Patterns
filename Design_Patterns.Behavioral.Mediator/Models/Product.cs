namespace Design_Patterns.Behavioral.Mediator.Models;
internal class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}
