using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_code_of_awp
{
    public partial class Q10aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Server-side validation
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtMobile.Text))
            {
                // Display an error message for required fields.
                // You can use a label or some other control for this.
                lblErrorMessage.Text = "All fields are required.";
                return;
            }

            if (!Regex.IsMatch(txtName.Text, "^[A-Za-z ]+$") || txtName.Text.Length > 25)
            {
                lblErrorMessage.Text = "Invalid name format.";
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 18 || age > 32)
            {
                lblErrorMessage.Text = "Age should be between 18 and 32.";
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"))
            {
                lblErrorMessage.Text = "Invalid email address.";
                return;
            }

            if (!Regex.IsMatch(txtMobile.Text, "^[0-9]{10}$"))
            {
                lblErrorMessage.Text = "Invalid mobile number.";
                return;
            }
            // If all validation passes, redirect to a new page and display user information.
            Response.Redirect($"Q10p2.aspx?name={txtName.Text}&age={txtAge.Text}&email={txtEmail.Text}&address={txtAddress.Text}&mobile={txtMobile.Text}");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            txtName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
        }
    }
}