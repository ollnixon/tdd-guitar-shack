namespace GuitarShack;

public class Order
{
    public Product AddItem(Product product, int saleQty)
    {
        LineItems = [new OrderLineItem(327, 1)];
        return product with { Hold = 1 };
    }

    public OrderLineItem[] LineItems = [];
}


public record OrderLineItem(int ProductId, int Quantity);