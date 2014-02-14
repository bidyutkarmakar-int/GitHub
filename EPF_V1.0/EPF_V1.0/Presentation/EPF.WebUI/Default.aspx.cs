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
    public partial class _Default : System.Web.UI.Page
    {
        //Instantiate of ServiceReference
        EPF.Service.Service1Client objServiceReference = new EPF.Service.Service1Client();

        /// <summary>
        /// Loading the Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCustomers();
            }
        }

        protected void btnHello_Click(object sender, EventArgs e)
        {
            //Class1 objCls1 = new Class1();
            //objCls1.message();
            //lblMsg.Text = objCls1.message();
            
        }

        /// <summary>
        /// Add to Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddToCustomer_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// RowCommand of GrdCustomer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grdCustomers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                string id = grdCustomers.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
                Response.Redirect("Update.aspx?Id=" + id);
            }
            else if (e.CommandName == "Delete")
            {
                int id = int.Parse(e.CommandArgument.ToString());
                DeleteCustomer(id);
                LoadCustomers();
            }
        }

        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <param name="id"></param>
        private  void DeleteCustomer(int id)
        {
            objServiceReference.DeleteCustomer(id);
        }

        /// <summary>
        /// Load the Customer Details
        /// </summary>
        private void LoadCustomers()
        {
            grdCustomers.DataSource = objServiceReference.SelectCustomer();
            grdCustomers.DataBind();
        }

        /// <summary>
        /// Redirect to UpdateCustomers.aspx
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateCustomers.aspx");
        }

        protected void grdCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// grdCustomers_PageIndexChanging event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grdCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCustomers.PageIndex = e.NewPageIndex;
            LoadCustomers();
        }

        protected void grdCustomers_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        /// <summary>
        /// grdCustomers_RowDataBound Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grdCustomers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkButton1");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure want to delete?" +
                DataBinder.Eval(e.Row.DataItem, "Id") + " ?')");
            }
        }

        /// <summary>
        /// grdCustomers_RowDeleting Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grdCustomers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Console.Write("delete");
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            //CustomerComponent cust = new CustomerComponent();
            //grdCustomers.DataSource = cust.SelectByName(txtFilterName.Text);
            //grdCustomers.DataBind();
        }

        /// <summary>
        /// Save Customer into DataBase.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txtName.Text;
            customer.Address = txtAdd.Text;
            customer.TelNo = txtTelNo.Text;
            customer.EmailId = txtEmailId.Text;
            
            objServiceReference.CreateCustomer(customer);
            Response.Redirect("Default.aspx");
        }
      
    }
}
