using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sum_Click(object sender, EventArgs e)
        {
            int Num1 = Int32.Parse(num1.Text);
            int Num2 = Int32.Parse(num2.Text);


            result.Text = Convert.ToString(Num1 + Num2);

        }

        protected void multiply_Click(object sender, EventArgs e)
        {
            int Num1 = Int32.Parse(num1.Text);
            int Num2 = Int32.Parse(num2.Text);


            result.Text = Convert.ToString(Num1 * Num2);
        }

        protected void subtract_Click(object sender, EventArgs e)
        {
            int Num1 = Int32.Parse(num1.Text);
            int Num2 = Int32.Parse(num2.Text);


            result.Text = Convert.ToString(Num1 - Num2);
        }
    }
}