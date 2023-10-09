using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_code_of_awp
{
    public partial class Q3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtFactorialInput.Text);
            int factorial = CalculateFactorial(input);
            lblResult.Text = "Factorial: " + factorial;
        }
        protected void btnConvertMoney_Click(object sender, EventArgs e)
        {
            decimal input = Convert.ToDecimal(txtMoneyInput.Text);
            string targetCurrency = ddlCurrency.SelectedValue; // Assuming you have a DropDownList for currency selection
            decimal convertedAmount = ConvertCurrency(input, targetCurrency);
            lblResult1.Text = $"Converted Amount: {convertedAmount.ToString("C")} {targetCurrency}";
        }
        protected void btnCalculateCube_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtCubeInput.Text);
            double cube = CalculateCube(input);
            lblResult2.Text = "Cube: " + cube;
        }
        private int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
        private decimal ConvertCurrency(decimal amount, string targetCurrency)
        {
            decimal convertedAmount = 0;           
            decimal usdToInrRate = 74.50M; // Replace with the actual USD to INR rate
            decimal cadToInrRate = 57.20M; // Replace with the actual CAD to INR rate
            decimal eurToInrRate = 88.25M; // Replace with the actual EUR to INR rate
            // Perform currency conversion based on the target currency
            switch (targetCurrency.ToUpper())
            {
                case "USD":
                    convertedAmount = amount / usdToInrRate;
                    break;
                case "CAD":
                    convertedAmount = amount / cadToInrRate;
                    break;
                case "EUR":
                    convertedAmount = amount / eurToInrRate;
                    break;
                default:
                    lblResult2.Text = "Invalid target currency.";
                    return 0; // Return 0 if the target currency is not recognized
            }

            return convertedAmount;
        }
        private double CalculateCube(double num)
        {
            return Math.Pow(num, 3);
        }
        protected void btnGeneratePrimes_Click(object sender, EventArgs e)
        {
            int maxNumber = Convert.ToInt32(txtMaxPrimeInput.Text);
            List<int> primeNumbers = GeneratePrimes(maxNumber);
            lblPrimeResult.Text = "Prime Numbers: " + string.Join(", ", primeNumbers);
        }

        private List<int> GeneratePrimes(int maxNumber)
        {
            List<int> primeNumbers = new List<int>();

            for (int number = 2; number <= maxNumber; number++)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
            }

            return primeNumbers;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}