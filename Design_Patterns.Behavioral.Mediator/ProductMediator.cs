using Design_Patterns.Behavioral.Mediator.Models;
using Design_Patterns.Behavioral.Mediator.Systems;

namespace Design_Patterns.Behavioral.Mediator;

internal class ProductMediator : IProductMediator
{
    private readonly ProductManager _productManager;
    private readonly InventoryManager _inventoryManager;
    private readonly OrderManager _orderManager;

    public ProductMediator(ProductManager productManager, InventoryManager inventoryManager, OrderManager orderManager)
    {
        _productManager = productManager;
        _productManager.SetMediator(this);


        _inventoryManager = inventoryManager;
        _inventoryManager.SetMediator(this);

        _orderManager = orderManager;
        _orderManager.SetMediator(this);
    }

    public void Notify(object sender, ProductMediatorEvents eventName, Product product)
    {
        Console.WriteLine($"--------> Sender: {sender}, Event name: {eventName} <--------");
        if (eventName == ProductMediatorEvents.ProductAdded)
        {
            Console.WriteLine($"Mediator: Product added. Updating inventory.");
            _inventoryManager.UpdateStock(product);
        }
        else if (eventName == ProductMediatorEvents.OrderPlaced)
        {
            Console.WriteLine("Mediator: Order placed. Checking inventory.");
            var availableStock = _inventoryManager.GetStock(product.Name);

            if (availableStock >= product.Quantity)
            {
                _inventoryManager.UpdateStock(new Product(product.Name, -product.Quantity));
            }
            else
            {
                Console.WriteLine($"Mediator: Not enough stock for '{product.Name}'");
            }

        }

    }
}

internal enum ProductMediatorEvents
{
    ProductAdded,
    OrderPlaced
}