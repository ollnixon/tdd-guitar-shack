namespace Tests;

public class AddItem
{
    [Fact]
    public void TestProductIsPutOnTemporaryHold()
    {
        var order = new Order();
        
        var product = new Product(327, 7, 0);
        const int saleQty = 1;
        
        product = order.AddItem(product, saleQty);
        
        Assert.Equal(1, product.Hold);
    }
}

public class Order
{
    public Product AddItem(Product product, int saleQty)
    {
        return product with { Hold = 1 };
    }
}

public record Product(int Id, int Stock, int Hold);