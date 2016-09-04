namespace HotelData.BusinessLogic.TestSuite
{
    [TestClass]
    public class CustomerBussinesLogic
    {
        [TestMethod]
        public void SelectCustomers()
        {
            SelectCustomer selectCustomer = new SelectCustomer();
            var customer = selectCustomer.GetustomerByFirstName("Mayuresh");
        }
    }
}