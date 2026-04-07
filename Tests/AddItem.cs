using GuitarShack;
using Xunit;

namespace Tests;

public class AddItemWithSufficientProductStock
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

    [Fact]
    public void TestProductIsInTheOrder()
    {
        var order = new Order();
        
        var product = new Product(327, 7, 0);
        const int saleQty = 1;
        
        order.AddItem(product, saleQty);
       
        Assert.Equal(new OrderLineItem(327, 1), order.LineItems.First());
    }
}

public class AddItemWithInsufficientProductStockAndNoStockOnHold
{
    [Fact]
    public void TestErrorIsRaisedProductHasInsufficientStock()
    {
        var order = new Order();
        var product = new Product(327, 1, 0, "Ibanez Tube Screamer");
        const int saleQty = 2;
        
        Assert.Throws<InsufficentStockException>(() => order.AddItem(product, saleQty));
    }
}
