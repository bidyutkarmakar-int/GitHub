﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 07-01-2014 09:53:37
namespace EPF.DAL
{
    
    /// <summary>
    /// There are no comments for SampleDBEntities in the schema.
    /// </summary>
    public partial class SampleDBEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new SampleDBEntities object using the connection string found in the 'SampleDBEntities' section of the application configuration file.
        /// </summary>
        public SampleDBEntities() : 
                base("name=SampleDBEntities", "SampleDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SampleDBEntities object.
        /// </summary>
        public SampleDBEntities(string connectionString) : 
                base(connectionString, "SampleDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SampleDBEntities object.
        /// </summary>
        public SampleDBEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "SampleDBEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Customer> Customer
        {
            get
            {
                if ((this._Customer == null))
                {
                    this._Customer = base.CreateQuery<Customer>("[Customer]");
                }
                return this._Customer;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Customer> _Customer;
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        public void AddToCustomer(Customer customer)
        {
            base.AddObject("Customer", customer);
        }
    }
    /// <summary>
    /// There are no comments for SampleDBModel.Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SampleDBModel", Name="Customer")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Customer : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        public static Customer CreateCustomer(int id)
        {
            Customer customer = new Customer();
            customer.Id = id;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Address in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this.OnAddressChanging(value);
                this.ReportPropertyChanging("Address");
                this._Address = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Address");
                this.OnAddressChanged();
            }
        }
        private string _Address;
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
        /// <summary>
        /// There are no comments for Property EmailId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailId
        {
            get
            {
                return this._EmailId;
            }
            set
            {
                this.OnEmailIdChanging(value);
                this.ReportPropertyChanging("EmailId");
                this._EmailId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("EmailId");
                this.OnEmailIdChanged();
            }
        }
        private string _EmailId;
        partial void OnEmailIdChanging(string value);
        partial void OnEmailIdChanged();
        /// <summary>
        /// There are no comments for Property TelNo in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string TelNo
        {
            get
            {
                return this._TelNo;
            }
            set
            {
                this.OnTelNoChanging(value);
                this.ReportPropertyChanging("TelNo");
                this._TelNo = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("TelNo");
                this.OnTelNoChanged();
            }
        }
        private string _TelNo;
        partial void OnTelNoChanging(string value);
        partial void OnTelNoChanged();
    }
}
