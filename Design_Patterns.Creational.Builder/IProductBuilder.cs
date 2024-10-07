namespace Design_Patterns.Creational.Builder;

internal interface IProductBuilder
{
    IProductBuilder SetName(string name);
    IProductBuilder SetPrice(decimal price);
    IProductBuilder SetCategory(string category);
    IProductBuilder SetDescription(string description);
    Product Build();
}
