using System;
using System.Collections.Generic;
using System.Linq;
//using System.Data.Linq;
//using System.Data.Linq.Mapping;
using System.Text;
using EPF.DAL;
using System.Diagnostics;
using System.Data;

namespace EPF.DAL
{
    
    public class CustomerDAC
    {

        /// <summary>
        /// Inserts an Customer row.
        /// </summary>
        /// <param name="Customer">An Customer object.</param>
        public Customer Create(Customer customer)
        {
            //SampleDBEntities ctx = SampleDBEntities.Context;
            SampleDBEntities ctx = new SampleDBEntities();
        
            try
            {
                ctx.AddToCustomer(customer);                    
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }           

            return customer;
        }


        /// <summary>
        /// Updates an Customer row.
        /// </summary>
        /// <param name="Customer">A Customer object.</param>
        public bool Update(Customer customer)
        {
            SampleDBEntities ctx = new SampleDBEntities();
            bool blnUpdate = false;
            try
            {
                Customer cust = (from e1 in ctx.Customer
                                 where e1.Id == customer.Id
                                 select e1).First();

                cust.Name = customer.Name;
                cust.Address = customer.Address;
                cust.EmailId = customer.EmailId;
                cust.TelNo = customer.TelNo;
                
                ctx.SaveChanges();
                blnUpdate = true;
                return blnUpdate;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
           
        }


        /// <summary>
        /// Returns a set of Customers that belongs to an employee
        /// </summary>
        /// <returns>A List of Customers.</returns>
        public List<Customer> Select()
        {
            List<Customer> resultsList = null;
            SampleDBEntities ctx = new SampleDBEntities();
            resultsList = ctx.Customer.ToList();

            return resultsList;
        }

        /// <summary>
        /// Delete Customer
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            SampleDBEntities ctx = new SampleDBEntities();
            Customer cust = ctx.Customer.First(c => c.Id == id);
            ctx.DeleteObject(cust);
            ctx.SaveChanges();
        }

        /// <summary>
        /// GetCustomer return a list of Customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomer(int id)
        {
            Customer custre = null;
            SampleDBEntities ctx = new SampleDBEntities();
            {
                custre = ctx.Customer.First(e => e.Id == id);
            }
            return custre;
        }
    }
}
