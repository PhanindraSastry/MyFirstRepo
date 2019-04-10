using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class Employee
    {
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Designation { get; set; }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Employee> lEmp = new List<Employee>();
                lEmp.Add(new Employee() { Name = "Siva", DOB = "12/12/1999", Designation = "Manager" });
                lEmp.Add(new Employee() { Name = "Shanker", DOB = "12/12/1999", Designation = "CEO" });
                lEmp.Add(new Employee() { Name = "Hara", DOB = "12/24/1987", Designation = "GM" });
                lEmp.Add(new Employee() { Name = "Rudra", DOB = "12/01/1999", Designation = "MD" });
                gv.DataSource = lEmp;
                gv.DataBind();
            }
        }
    }
}