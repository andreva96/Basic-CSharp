using System;
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

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(()=> customer.GetOrdersByName(""));
            Assert.Equal("Hello",exceptionDetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }


    }
}
