namespace GuitarShack;

public class Order
{
    public Product AddItem(Product product, int saleQty)
    {
        return product with { Hold = 1 };
    }
}