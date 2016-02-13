using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Linq1; 

namespace LinqTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void TestFind()
        {
           CustomerRepository repository = new CustomerRepository() ;
           List<Customer> customerList = repository.Retrieve();

           Customer foundCustomer = repository.Find(customerList, 1);

           Assert.IsTrue(foundCustomer.CustomerId == 1); 
        }

        [TestMethod]
        public void TestConvertToTitleCase()
        {
            var source = "this is the source";
            var result = "This Is The Source";

            source = source.ConvertToTitleCase();

            Assert.IsNotNull(source); 
            Assert.AreEqual(source, result); 
            
        }
    }
}
