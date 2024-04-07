public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // shipping cost based on location
        if (customer.IsInUSA())
        {
            totalCost += 5; // US shipping
        }
        else
        {
            totalCost += 35; // International shipping
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer Name: {customer.GetName()}\n";
        shippingLabel += $"Address: {customer.GetAddress().GetAddressString()}\n";
        return shippingLabel;
    }
}