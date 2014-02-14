using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EPF.DAL;

namespace EPF.Service
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [OperationContract]
        Customer CreateCustomer(Customer customer);

        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [OperationContract]
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// SelectCustomer
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Customer> SelectCustomer();

        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <param name="id"></param>
        [OperationContract]
        void DeleteCustomer(int id);

        /// <summary>
        /// GetCustomerDetails
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        Customer GetCustomerDetails(int id);

        //TODO: Add your service operations here
    }
}
