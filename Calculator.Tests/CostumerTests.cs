using Xunit;

namespace XUnitExample.Tests
{
    public class CostumerTests
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var costumer = new Customer();
            Assert.NotNull(costumer.Name);
            Assert.False(string.IsNullOrEmpty(costumer.Name));
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 40);
        }
    }
}
