using Bogus;
using Lifecycle.Domain.Entities;

namespace Lifecycle.Tests.Unit.Domain.Fixtures;

public class CustomerFixture
{
    public Customer FakerPrivate = new(
    new Faker().Random.Guid(),
    new Faker().Person.FullName
    );
    
    public readonly Customer CustomerConstructor;

    public CustomerFixture()
    {
        Faker fakerConstructor = new();
        CustomerConstructor = new Customer(fakerConstructor.Random.Guid(), fakerConstructor.Person.FullName);
    }
}