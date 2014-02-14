using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EPF.DAL;
using EPF.BL;

namespace EPF.Service
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
    public class Service1 : IService1
    {
        CustomerComponent objCustomerComponent = new CustomerComponent();

        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public Customer CreateCustomer(Customer customer)
        {
            return objCustomerComponent.CreateCustomer(customer);
        }

        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool UpdateCustomer(Customer customer)
        {
            return objCustomerComponent.UpdateCustomer(customer);
        }

        /// <summary>
        /// SelectCustomer
        /// </summary>
        /// <returns></returns>
        public List<Customer> SelectCustomer()
        {
            return objCustomerComponent.ListCustomer();
        }

        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCustomer(int id)
        {
            objCustomerComponent.DeleteCustomer(id);
        }

        /// <summary>
        /// getCustomerDetails
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomerDetails(int id)
        {
            return objCustomerComponent.GetCustomerInfo(id);
        }

      
    }
}
