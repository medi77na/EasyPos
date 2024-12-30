namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GGetByIdAsync(CustomerId id);
    Task Add(Customer customer); 

}
