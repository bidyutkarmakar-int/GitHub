using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Diagnostics;
using System.ComponentModel;
using EPF.WebUI.Utility;
using Int.Util;

namespace EPF.WebUI
{
    public partial class DotNetSample : System.Web.UI.Page
    {
        TraceSourceLog traceSourceLog=new TraceSourceLog();

        #region INotifyError Members
        //public event NotifyError<object, NotificationType, string> OnNotifyError;
        #endregion

        public string connectionString = null;

        //Property 
        private string myName = "N/A";

        //Constructor Sample
        public bool isInitialized;
        public DotNetSample()
        {
            isInitialized = true;
        }

        //Enum Declaration
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        protected void Page_Load(object sender, EventArgs e)
        {
          //string msg=OnNotifyError(this, NotificationType.Information, "Page_Load");
            
            traceSourceLog.LogInfo(sender.ToString(), e.ToString(),"Page_Load Event");
        }
        //Enum Sample
        public void btnEnum_Click(object sender, EventArgs e)
        {
            //int x = 0;
            int x = (int)Days.Sun;
            Console.WriteLine("Sun = {0}", x);


            // C#.NET version
            MyEnum MyEnumVal;
            int i;

            // Retrieve an enum member by its value
            i = 2;
            MyEnumVal = (MyEnum)i;
            //Debug.WriteLine(MyEnumVal.ToString());

            // If the specified value is not an enum member,
            // MyEnumVal receives the value anyway
            i = 4;
            MyEnumVal = (MyEnum)i;
            //Debug.WriteLine(MyEnumVal.ToString());    // The output is "4"

            // Test for allowed enum values
            if (!MyEnum.IsDefined(typeof(MyEnum), 4))
                //Debug.WriteLine("The value of 4 is not defined in the Enum");


            //retrieve an Enum member given its name
            // C#.NET version
            MyEnumVal = (MyEnum)TypeDescriptor.GetConverter(MyEnumVal).ConvertFrom("gamma");
            //Debug.WriteLine(MyEnumVal.ToString());    // The output is "gamma"

            // Dactyl's alternative
            MyEnumVal = (MyEnum)Enum.Parse(typeof(MyEnum), "gamma");
            
        }

        //Interface
        protected void btnInterface_Click(object sender, EventArgs e)
        {
            ImplementClass objImplClass = new ImplementClass();
            objImplClass.abc();
            objImplClass.xyz();
        }

        //Static Class
        protected void btnStatic_Click(object sender, EventArgs e)
        {
            Perl.Blend();
        }

        protected void btnGlobal_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Global Variable = {0}", Global.globalVar);
        }

        //Property Declaration
        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }
        //Property Declaration
        protected void btnProperty_Click(object sender, EventArgs e)
        {
            Name = "Sample";
            Console.WriteLine("Property Declaration = {0}", Name);
        }

        protected void btnErrorHandling_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                 
                    using (SqlCommand command = new SqlCommand("SELECT TOP 2 * FROM table1", con))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1} {2}",
                            reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                
            }

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
            
        }

        #endregion
    }

    //Interface
    public interface ISample
    {
         void abc();
    }
    public interface ISampleOne
    {
        void xyz();
    }
    public class ImplementClass:ISample, ISampleOne
    {
        #region ISample Members
        public void abc()
        {
            System.Console.WriteLine("Interface ISample Implementation.");
        }
        #endregion

        #region ISampleOne Members
        public void xyz()
        {
            System.Console.WriteLine("Interface ISample Implementation.");
        }
        #endregion
    }
    public class ImplementationClassOne : ISample
    {
        public void abc()
        {
            System.Console.WriteLine("Hello Interface ISample Implementation.");
        }
    }
    //Static Class
    public static class Perl
    {
        //Static Variable
        public static bool _ok;

        //Can only have static methods in static classes.
        public static void Blend()
        {
            Console.WriteLine("Blended");
        }
    }
    //Global Variable
    public class Global
   {
       public static int globalVar = 10;
   }

}

   



