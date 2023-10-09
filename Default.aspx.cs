using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_code_of_awp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string str1 = Request.Cookies["MyCookie"].Value;
                Response.Write(str1);
            }            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string str1 = Request.Cookies["MyCookie"].Value;
            Response.Write(str1);
        }
    }
}