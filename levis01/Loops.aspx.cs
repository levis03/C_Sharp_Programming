using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace levis01
{
    public partial class Loops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Declare global variable
        int k; //k shall be the loop variable
        protected void Button2_Click(object sender, EventArgs e)
        {
            k = 100;

            {
                Response.Write("Working with the while loop " + "<br>");
                while (k > 0)
                {
                    if (k % 2 == 1)
                    {
                        Response.Write(k + "<br>");
                    }
                }
                k--;
            }
        }

        protected void btnDowhile_Click(object sender, EventArgs e)
        {
            k = 100;
            do
            {
                Response.Write("Working with do while " + "<br>");
                {
                    if (k % 2 == 1)
                        Response.Write(k + "<br>");

                }
                k--;
            } while (k > 0);
        }

        protected void btnForloop_Click(object sender, EventArgs e)
        {
            Response.Write("For loop <br>");
            for (k = 100; k > 0; k--)
            {
                if (k % 2 == 1)
                {
                    Response.Write(k + "<br>");
                }
            }
        }

        protected void btnforeach_Click(object sender, EventArgs e)
        {
            int[] age = { 4, 8, 10, 45, 30, 12, 67, 24, 21, 89 };
            int total = 0;
            //start foreach loop
            foreach (int m in age)
            {
                if (m > 18)
                {
                    Response.Write(m + "<br>");
                    total++;

                }
            }
            Response.Write("Total number of people above 18:\t" + total);

        }
    }
}