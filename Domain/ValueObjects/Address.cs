namespace Domain.ValueObjects;
public partial record Address
{
    public Address(string country, string city, string state, string postalCode)
    {
        Country = country;
        City = city;
        State = state;
        PostalCode = postalCode;
    }

    public string Country { get; init; }
    public string City { get; init; }    
    public string State { get; init; }
    public string PostalCode { get; init; }

    public static Address Create(string country, string city, string state, string postalCode)
    {
        if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(city) || 
            string.IsNullOrEmpty(state) || string.IsNullOrEmpty(postalCode))
        {
            return null;
        }
        return new Address(country, city, state, postalCode);
    }
}
