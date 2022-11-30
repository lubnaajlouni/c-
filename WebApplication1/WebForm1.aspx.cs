using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
       

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(TextBox1.Text);
            double number2 = Convert.ToDouble(TextBox2.Text);
            double s = number1 - number2;
            TextBox3.Text = s.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(TextBox1.Text);
            double number2 = Convert.ToDouble(TextBox2.Text);
            double s = number1 + number2;
            TextBox3.Text = s.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(TextBox1.Text);
            double number2 = Convert.ToDouble(TextBox2.Text);
            double s = number1 * number2;
            TextBox3.Text = s.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(TextBox1.Text);
            double number2 = Convert.ToDouble(TextBox2.Text);
            double s = number1 / number2;
            TextBox3.Text = s.ToString();
        }
    }
}