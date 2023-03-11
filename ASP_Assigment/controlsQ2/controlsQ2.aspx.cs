using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validator
{
    public partial class controlsQ2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex==0)
            {
                Image1.ImageUrl = "img/raddish.jpg";
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                Image1.ImageUrl = "img/Mustard-Leaves.jpeg";
            }
            else
                Image1.ImageUrl = "img/cauliflower.jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex > -1)
            {
                int cost = DropDownList1.SelectedIndex;
                Price.Text = "price:";
                if (cost == 0)
                    Price.Text += 20;
                else if (cost == 1)
                    Price.Text += 60;
                else
                    Price.Text += 40;
            }
        }
    }
}