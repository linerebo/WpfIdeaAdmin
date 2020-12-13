using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfIdeaAdmin.Model;

namespace WpfIdeaAdmin.UnitTests
{
    [TestClass]
    public class AddCustomerTests
    {
        [TestMethod]
        public void CheckInputNewCustomer()
        {
            //Arrange
            var NewCustomer = new Customer();

            //Act
            var result = (NewCustomer.CustomerName == null);

            //Assert
            Assert.IsTrue(result);
           
        }
    }
}
