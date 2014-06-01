using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OwinApp
{
    public class CustomerController : ApiController
    {
        public CustomerController()
        {
        }
       

        // GET api/<controller>/5
         [HttpGet]
        public Customer Get(int customerId)
        {
            return new Customer()
            {
                ID = customerId,
                LastName = "Smith",
                FirstName = "Mary",
                HouseNumber = "333",
                Street = "Main Street NE",
                City = "Redmond",
                State = "WA",
                ZipCode = "98053"
            };
        }

      
    }
}