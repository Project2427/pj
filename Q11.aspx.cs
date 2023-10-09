using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_code_of_awp
{
    public partial class Q11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        string time = DateTime.Now.ToLongTimeString();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Showing time from panel" + time;
        }

        protected void btntotal_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "Showing time from outside" + time;
        }
    }
}