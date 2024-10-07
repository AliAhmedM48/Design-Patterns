namespace Design_Patterns.Creational.Builder;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ProductBuilder productBuilder = new ProductBuilder();

        var product = productBuilder
            .SetName("Laptop")
            .SetCategory("Dell")
            .SetPrice(20_000)
            .Build();

        Console.WriteLine(product);

    }
}
