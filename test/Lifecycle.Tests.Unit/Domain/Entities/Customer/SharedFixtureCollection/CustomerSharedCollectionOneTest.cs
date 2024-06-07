using Lifecycle.Tests.Unit.Domain.Fixtures;
using Xunit.Abstractions;

namespace Lifecycle.Tests.Unit.Domain.Entities.Customer.SharedFixtureCollection;

[Collection("Customer entity fixture")]
public class CustomerSharedCollectionOneTest : IClassFixture<CustomerFixture>
{
    private readonly CustomerFixture _fixture;
    private readonly ITestOutputHelper _testOutputHelper;

    public CustomerSharedCollectionOneTest(CustomerFixture fixture, ITestOutputHelper testOutputHelper)
    {
        _fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void MethodOne()
    {
        _testOutputHelper.WriteLine($"Customer private: {_fixture.FakerPrivate.Id} - {_fixture.FakerPrivate.FullName}");
        _testOutputHelper.WriteLine($"Customer constructor: {_fixture.CustomerConstructor.Id} - {_fixture.CustomerConstructor.FullName}");
    }

    [Fact]
    public void MethodTwo()
    {
        _testOutputHelper.WriteLine($"Customer private: {_fixture.FakerPrivate.Id} - {_fixture.FakerPrivate.FullName}");
        _testOutputHelper.WriteLine($"Customer constructor: {_fixture.CustomerConstructor.Id} - {_fixture.CustomerConstructor.FullName}");
    }
}