using Xunit;

namespace XUnitExample.Tests
{
    [Collection("Customer")]
    public class CustomerFixture
    {
        public Customer Cust => new Customer();
    }
}
