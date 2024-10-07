using System.Text.Json;

namespace Design_Patterns.Creational.Builder;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public override string ToString()
    {
        //return $"Name:{Name}, Price:{Price:C}, Category:{Category}, Description:{Description}";
        return JsonSerializer.Serialize(this);
    }
}
