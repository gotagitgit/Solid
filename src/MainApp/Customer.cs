namespace MainApp;

internal class Customer(int customerId, string name)
{
    public int CustomerId { get; } = customerId;

    public string Name { get; } = name;
}
