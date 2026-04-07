namespace GuitarShack;

public class Order
{
    public Product AddItem(Product product, int saleQty)
    {
        LineItems = [new OrderLineItem(product.Id, saleQty)];
        return product with { Hold = 1 };
    }

    public OrderLineItem[] LineItems = [];
}


public record OrderLineItem(int ProductId, int Quantity);