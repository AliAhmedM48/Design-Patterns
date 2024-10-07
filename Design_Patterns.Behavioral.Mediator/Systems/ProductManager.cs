using Design_Patterns.Behavioral.Mediator.Models;

namespace Design_Patterns.Behavioral.Mediator.Systems;

internal class ProductManager : IMediatorComponent
{
    private IProductMediator _mediator;

    public void SetMediator(IProductMediator mediator)
    {
        _mediator = mediator;
    }

    public void AddProduct(Product product)
    {
        Console.WriteLine($"Product Manager: Added product '{product.Name}', Q: {product.Quantity}");
        _mediator.Notify(this, ProductMediatorEvents.ProductAdded, product);
    }
}
