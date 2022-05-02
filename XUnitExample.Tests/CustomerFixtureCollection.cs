using Xunit;

namespace XUnitExample.Tests
{
    [CollectionDefinition("Customer")]
    public class CustomerFixtureCollection :ICollectionFixture<CustomerFixture>
    {

    }
}
