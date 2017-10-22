using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQL_Conncetion
{
    public partial class TestCustomControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (!IsPostBack)
           // {
                MyControl control = (MyControl)LoadControl("~/MyControl.ascx");
                control.ID = "MyControl";
                Label label1 = (Label)control.FindControl("Label");
                label1.Text = "Types of Animals:";
                DropDownList dropDown = (DropDownList)control.FindControl("DropDownList");
                ListItem item1 = new ListItem("Bird", "1");//text and value
                ListItem item2 = new ListItem("Mammal", "2");
                ListItem item3 = new ListItem("Reptile", "3");
                dropDown.Items.Add(item1);
                dropDown.Items.Add(item2);
                dropDown.Items.Add(item3);


                PlaceHolder1.Controls.Add(control);

               // PlaceHolder1.Controls.Add(LoadControl("~/MyControl.ascx"));
          //  }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyControl myControl = (MyControl)PlaceHolder1.FindControl("MyControl");
            if (myControl != null)
            {
                DropDownList dropDown = (DropDownList)myControl.FindControl("DropDownList");
                Button1.Text = dropDown.SelectedItem.Text;
            }
        }
    }
}