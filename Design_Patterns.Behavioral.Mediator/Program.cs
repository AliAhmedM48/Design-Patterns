using Design_Patterns.Behavioral.Mediator.Models;
using Design_Patterns.Behavioral.Mediator.Systems;

namespace Design_Patterns.Behavioral.Mediator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region Mediator Pattern with Direct References


        //ProductManager productManager = new ProductManager();
        //InventoryManager inventoryManager = new InventoryManager();
        //OrderManager orderManager = new OrderManager();

        //ProductMediator mediator = new ProductMediator(productManager, inventoryManager, orderManager);

        //mediator.AddProduct("Laptop", 50);
        //mediator.PlaceOrder("Laptop", 10);
        //mediator.PlaceOrder("Laptop", 60);

        #endregion

        #region Mediator Pattern with Notifications
        ProductManager productManager = new ProductManager();
        InventoryManager inventoryManager = new InventoryManager();
        OrderManager orderManager = new OrderManager();

        ProductMediator mediator = new ProductMediator(productManager, inventoryManager, orderManager);
        Console.WriteLine("\n-----------------------productManager.AddProduct\n");

        Product newLaptop = new Product("Laptop", 20);
        productManager.AddProduct(newLaptop);
        productManager.AddProduct(newLaptop);

        Console.WriteLine("\n-----------------------orderManager.ProcessOrder\n");
        Product oldLaptop = new Product("Laptop", 25);
        orderManager.ProcessOrder(oldLaptop);

        orderManager.ProcessOrder(oldLaptop);

        #endregion

    }
}

