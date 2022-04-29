namespace XUnitExample
{
    public class Customer
    {
        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }

        public string Name => "Andre";
        public int Age => 35;
    }

    public class LoyalCustomer : Customer
    {
        public int Discount
        {
            get;
            set;
        }

        public LoyalCustomer()
        {
            Discount = 10;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if(orderCount <= 100)
            {
                return new Customer();
            }
            else
            {
                return new LoyalCustomer();
            }
        }    
    }
}
