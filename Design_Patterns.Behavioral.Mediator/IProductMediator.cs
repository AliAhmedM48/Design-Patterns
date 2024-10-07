using Design_Patterns.Behavioral.Mediator.Models;

namespace Design_Patterns.Behavioral.Mediator;
#region Mediator Pattern with Notifications
internal interface IProductMediator
{
    void Notify(object sender, ProductMediatorEvents eventName, Product product);
}

#endregion