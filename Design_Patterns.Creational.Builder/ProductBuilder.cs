namespace Design_Patterns.Creational.Builder;

internal class ProductBuilder : IProductBuilder
{
    private Product _product;
    public ProductBuilder()
    {
        _product = new Product();
    }

    public Product Build()
    {
        return _product;
    }

    public IProductBuilder SetCategory(string category)
    {
        _product.Category = category;
        return this;
    }

    public IProductBuilder SetDescription(string description)
    {
        _product.Description = description;
        return this;
    }

    public IProductBuilder SetName(string name)
    {
        _product.Name = name;
        return this;
    }

    public IProductBuilder SetPrice(decimal price)
    {
        _product.Price = price;
        return this;
    }
}
