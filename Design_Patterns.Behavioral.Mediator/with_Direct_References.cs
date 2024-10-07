namespace Design_Patterns.Behavioral.Mediator;

#region Mediator Pattern with Direct References

//internal class ProductManager
//{
//    public void AddProduct(string productName)
//    {
//        Console.WriteLine($"Product Manager: Added Product '{productName}'.");
//    }
//}

//internal class InventoryManager
//{
//    private Dictionary<string, int> inventory = new Dictionary<string, int>();
//    public void UpdateStock(string productName, int quantity)
//    {
//        if (!inventory.ContainsKey(productName))
//        {
//            inventory[productName] = 0;
//        }

//        inventory[productName] += quantity;

//        Console.WriteLine($"Inventory Manager: Updated stock for '{productName}', new stock: {inventory[productName]}");
//    }

//    public int GetStock(string productName)
//    {
//        return inventory.ContainsKey(productName) ? inventory[productName] : 0;
//    }
//}

//internal class OrderManager
//{
//    public void ProcessOrder(string productName, int quantity)
//    {
//        Console.WriteLine($"Order Manager: Processing order for {quantity} units of '{productName}'");
//    }
//}

//internal class ProductMediator
//{

//    private readonly ProductManager _ProductManager;
//    private readonly InventoryManager _InventoryManager;
//    private readonly OrderManager _OrderManager;
//    public ProductMediator(ProductManager productManager, InventoryManager inventoryManager, OrderManager orderManager)
//    {
//        _ProductManager = productManager;
//        _InventoryManager = inventoryManager;
//        _OrderManager = orderManager;
//    }

//    public void AddProduct(string productName, int quantity)
//    {
//        Console.WriteLine($"Mediator: Adding new product '{productName}'");
//        _ProductManager.AddProduct(productName);
//        _InventoryManager.UpdateStock(productName, quantity);
//    }

//    public void PlaceOrder(string productName, int quantity)
//    {
//        Console.WriteLine($"Mediator: Placing order for {quantity} units of '{productName}'");
//        var availableStock = _InventoryManager.GetStock(productName);
//        if (availableStock >= quantity)
//        {
//            _OrderManager.ProcessOrder(productName, quantity);
//            _InventoryManager.UpdateStock(productName, -quantity);
//        }
//        else
//        {
//            Console.WriteLine($"Mediator: Not enough stock for '{productName}'");
//        }
//    }
//}

#endregion
