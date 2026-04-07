namespace GuitarShack;

public class Order
{
    public Product AddItem(Product product, int saleQty)
    {
        if (product.Stock < saleQty)
            throw new InsufficientStockException();
        
        LineItems = [new OrderLineItem(product.Id, saleQty)];
        return product with { Hold = 1 };
    }

    public OrderLineItem[] LineItems = [];
}


public record OrderLineItem(int ProductId, int Quantity);

public class InsufficientStockException : Exception;