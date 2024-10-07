using Design_Patterns.Behavioral.Mediator.Models;

namespace Design_Patterns.Behavioral.Mediator.Systems;

internal class InventoryManager : IMediatorComponent
{
    private Dictionary<string, int> inventory = new Dictionary<string, int>();

    private IProductMediator _mediator;
    public void SetMediator(IProductMediator mediator)
    {
        _mediator = mediator;
    }

    public void UpdateStock(Product product)
    {
        if (!inventory.ContainsKey(product.Name))
        {
            inventory[product.Name] = 0;
        }
        inventory[product.Name] += product.Quantity;
        Console.WriteLine($"Inventory Manager: Updated stock for '{product.Name}', new stock: {inventory[product.Name]}");
    }

    public int GetStock(string productName)
    {
        return inventory.ContainsKey(productName) ? inventory[productName] : 0;
    }

}

