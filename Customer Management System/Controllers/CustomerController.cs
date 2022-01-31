using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Customer_Management_System.Models;

namespace Customer_Management_System.Controllers
{
    public class CustomerController : ApiController
    {
        ContextEntities db = new ContextEntities();

        //GET
        public IEnumerable<Customer> Get()
        {
            return db.Customers.ToList();
        }
        public Customer Get(int id)
        {
            Customer customer = db.Customers.Find(id);
            return customer;
        }
        //POST
         public string Post(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return "Data Stored";
        }
        //PUT
        public string Put(int id, Customer customer)
        {
            var customer1 = db.Customers.Find(id);
            customer1.name = customer.name;
            customer1.iscomplete = customer.iscomplete;
            customer1.completedat = customer.completedat;
            customer1.createdby = customer.createdby;
            customer1.createdat = customer.createdat;
            customer1.updatedby = customer.updatedby;
            customer1.updatedat = customer.updatedat;
            customer1.deletedby = customer.deletedby;
            customer1.deletedat = customer.deletedat;

            db.Entry(customer1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return "Data Updated";
        }
        //DELETE
        public string Delete(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return "Data Deleted";
        }

    }
}
