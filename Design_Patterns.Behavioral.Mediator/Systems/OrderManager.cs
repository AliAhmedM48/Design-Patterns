using Design_Patterns.Behavioral.Mediator.Models;

namespace Design_Patterns.Behavioral.Mediator.Systems;

internal class OrderManager : IMediatorComponent
{
    private IProductMediator _mediator;
    public void SetMediator(IProductMediator mediator)
    {
        _mediator = mediator;
    }

    public void ProcessOrder(Product product)
    {
        Console.WriteLine($"Order Manager: Processing order for {product.Quantity} units of '{product.Name}'");
        _mediator.Notify(this, ProductMediatorEvents.OrderPlaced, product);
    }
}