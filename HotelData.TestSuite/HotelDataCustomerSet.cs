
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Data;

namespace HotelData.TestSuite
{
    [TestClass]
    public class HotelDataCustomerTest
    {
        [TestMethod]
        public void TestCustomerInsert()
        {
            CustomerDBImpl customerdbImple = new CustomerDBImpl();
            customerdbImple.InsertCustomer("Mayuresh", "Bhanushali", "mbhanushali@tavisca.com", "123456789");
        }

        [TestMethod]
        public void SelectCusotmer()
        {
            //CustomerDBImpl customerdbImple = new CustomerDBImpl();
            //var dataset = customerdbImple.SelectCusotmer("Sagar");
        }

        [TestMethod]
        public void PaserCustomer()
        {
            TranslateCustomer translateCustomer = new TranslateCustomer();
            translateCustome
        }
    }
}
