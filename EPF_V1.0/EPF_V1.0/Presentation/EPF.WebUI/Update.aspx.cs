using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EPF.BL;
using EPF.DAL;

namespace EPF.WebUI
{
    public partial class Update : System.Web.UI.Page
    {
        private int Id = 0;
        CustomerComponent custc = new CustomerComponent();
        Customer cust = new Customer();
        EPF.Service.Service1Client objServiceReference = new EPF.Service.Service1Client();

        /// <summary>
        /// Load Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                Id = int.Parse(Request.QueryString["Id"]);
            }

        }

        /// <summary>
        /// Update records into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            bool blnResult = false;

            if (Id > 0)
            {
                cust = new Customer();
                LoadCustomer();
                cust.Name = txtName.Text;
                cust.Address = txtAdd.Text;
                cust.TelNo = txtTelNo.Text;
                cust.EmailId = txtEmailId.Text;

                blnResult = objServiceReference.UpdateCustomer(cust);
                if (blnResult == true)
                {
                    //lblMsg.Text = "Record Updated.";
                }

            }
            else
            {
                // agregar    
                cust = new Customer();
                cust.Name = txtName.Text;
                cust.Address = txtAdd.Text;
                cust.TelNo = txtTelNo.Text;
                cust.EmailId = txtEmailId.Text;

                objServiceReference.CreateCustomer(cust);
            }
            Response.Redirect("Default.aspx");
        }


        /// <summary>
        /// Load Customer details
        /// </summary>
        private void LoadCustomer()
        {
            cust = objServiceReference.GetCustomerDetails(Id);
            cust.Name = txtName.Text;
            cust.Address = txtAdd.Text;
            cust.EmailId = txtEmailId.Text;
            cust.TelNo = txtTelNo.Text;
        }

        /// <summary>
        /// Back 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
