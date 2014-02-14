using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//using System.Transactions;
//using EPF.BL.Entities ;
using EPF.DAL;
using Int.Util;

namespace EPF.BL
{
    public class CustomerComponent : ILogger
    {

        CustomerDAC objCustomerDAC = new CustomerDAC();
        /// <summary>
        /// Submit an Customer.
        /// </summary>
        /// <param name="Customer">An Customer object.</param>
        public Customer CreateCustomer(Customer customer)
        {
            Console.WriteLine("Submitting... ");                       

            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
                try
                {
                    customer = objCustomerDAC.Create(customer);                   
                    //ts.Complete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            //}

            Console.WriteLine("New CustomerID = " + customer.Id.ToString());

            return customer;
        }

        /// <summary>
        /// Submit changes of customer
        /// </summary>
        /// <param name="Customer">customer for update</param>
        /// <returns>a Customer object</returns>
        public bool UpdateCustomer(Customer customer)
        {
            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
            bool blnUpdate = false;
                try
                {

                    blnUpdate = objCustomerDAC.Update(customer);                   
                    //ts.Complete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            //}

                return blnUpdate;
        }


        /// <summary>
        /// Return a list of Customer
        /// </summary>
        /// <returns></returns>
        public List<Customer> ListCustomer()
        {
            // Retrieve data.
            CustomerDAC dac = new CustomerDAC();
            return dac.Select();
        }

      
        /// <summary>
        /// Delete a customer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public void DeleteCustomer(int id)
        {
            CustomerDAC dac = new CustomerDAC();
            dac.Delete(id);
        }

        /// <summary>
        /// Get a customer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Customer GetCustomerInfo(int id)
        {

            return objCustomerDAC.GetCustomer(id);
        }

        #region ILogger Members

        public void Debug(string message, params object[] args)
        {
            
        }

        public void Debug(string message, Exception exception, params object[] args)
        {
            
        }

        public void Debug(object item)
        {
            
        }

        public void Fatal(string message, params object[] args)
        {
            
        }

        public void Fatal(string message, Exception exception, params object[] args)
        {
            
        }

        public void LogInfo(string message, params object[] args)
        {
            
        }

        public void LogWarning(string message, params object[] args)
        {
            
        }

        public void LogError(string message, params object[] args)
        {
            
        }

        public void LogError(string message, Exception exception, params object[] args)
        {
            //Log error into file
            
        }

        #endregion
    }
}
