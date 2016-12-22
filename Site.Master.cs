using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Class1;

namespace lab_2
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 1;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 2;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 3;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 4;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 5;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 6;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 7;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 8;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 9;
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
                TextBox3.Text = TextBox3.Text + "+";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + "-";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text  + "*";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + "/";
        }
        
        protected void Button15_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox3.Text + 0;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            string input = TextBox3.Text;
            double result = calculate(input);
            TextBox3.Text = Convert.ToString(result);
        }

        public double calculate(string input)
        {
            Class1.Class1 class1 = new Class1.Class1();
            return class1.Calculate(input);
        }


    }

}