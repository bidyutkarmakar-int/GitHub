using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPF.BL.Entities
{
    [DataContract]
    [Serializable]
    public class Customer
    {
        [DataMember]
        public Int64 CustomerID { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string CustomerAddress { get; set; }

        [DataMember]
        public string CustomerEmailId { get; set; }

        [DataMember]
        public string CustomerMobileNo { get; set; }

    }
}
