using Domain.ValueObjects;
using MediatR;

namespace Application.Customers.Create;

public record CreateCustomerComand(
    string Name,
    string LastName,
    string Email,
    string PhoneNumber,
    string Country,
    string City,
    string State,
    string PostalCode) : IRequest<Unit>;