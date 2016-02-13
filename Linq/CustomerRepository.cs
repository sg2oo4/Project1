using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq1
{
    public class CustomerRepository
    {
        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
          {new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Freddo", 
                    LastName = "Baggins", 
                    EmailAddress = "fb@nob.me",
                    CustomerTypeId = 1}, 
           new Customer()
                {
                    CustomerId = 2,
                    FirstName = "Bilb", 
                    LastName = "Baggins", 
                    EmailAddress = "bb@nob.me",
                    CustomerTypeId = 1},
           new Customer()
                {
                    CustomerId = 3,
                    FirstName = "Samwise", 
                    LastName = "Gamgee", 
                    EmailAddress = "sg@nob.me",
                    CustomerTypeId = 1}, 
           new Customer()
                {
                    CustomerId = 4,
                    FirstName = "Rosie", 
                    LastName = "Cotton", 
                    EmailAddress = "rc@nob.me",
                    CustomerTypeId = 1}};

            return custList; 
        }

        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            //var query = from c in customerList
            //            where c.CustomerId == customerId
            //            select c;


            //Func<Customer,bool> func = c => c.CustomerId == customerId; 

            foundCustomer = customerList.FirstOrDefault(c => c.CustomerId == customerId); 
           
           return foundCustomer; 

        }
    }
}
