using System;
using Xunit;

namespace XUnitExample.Tests
{
    [Collection("Customer")]
    public class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;
        
        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void CheckNameNotEmpty()
        {
            var Customer = _customerFixture.Cust;
            Assert.NotNull(Customer.Name);
            Assert.False(string.IsNullOrEmpty(Customer.Name));
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = _customerFixture.Cust;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = _customerFixture.Cust;
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
