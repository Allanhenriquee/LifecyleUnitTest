using Bogus;
using Xunit.Abstractions;

namespace Lifecycle.Tests.Unit.Domain.Entities.Customer.Default;

public class CustomerTest
{
    private readonly Lifecycle.Domain.Entities.Customer _customerPrivate = new(
        new Faker().Random.Guid(),
        new Faker().Person.FullName
    );

    private readonly Lifecycle.Domain.Entities.Customer _customerConstructor;

    private readonly ITestOutputHelper _testOutputHelper;

    public CustomerTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;

        Faker fakerConstructor = new();
        _customerConstructor = new Lifecycle.Domain.Entities.Customer(fakerConstructor.Random.Guid(), fakerConstructor.Person.FullName);
    }

    [Fact]
    public void MethodOne()
    {
        _testOutputHelper.WriteLine($"Customer private: {_customerPrivate.Id} - {_customerPrivate.FullName}");
        _testOutputHelper.WriteLine($"Customer constructor: {_customerConstructor.Id} - {_customerConstructor.FullName}");
    }

    [Fact]
    public void MethodTwo()
    {
        _testOutputHelper.WriteLine($"Customer private: {_customerPrivate.Id} - {_customerPrivate.FullName}");
        _testOutputHelper.WriteLine($"Customer constructor: {_customerConstructor.Id} - {_customerConstructor.FullName}");
    }
}