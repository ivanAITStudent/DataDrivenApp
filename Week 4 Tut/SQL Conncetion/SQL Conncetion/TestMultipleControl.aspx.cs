using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQL_Conncetion
{
    public partial class TestMultipleControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//if not a bounce to the server for an update
            {
                for(int i = 1 ; i <= 15; i++){
                    ListItem listItem = new ListItem();
                    listItem.Text = "Option " + i;
                    listItem.Value = ""+i;

                    ListBox1.Items.Add(listItem);
                    DropDownList1.Items.Add(listItem);
                    CheckBoxList1.Items.Add(listItem);
                    RadioButtonList1.Items.Add(listItem);
                }
                ListBox1.SelectionMode = ListSelectionMode.Multiple;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<b>Selected items for listBox1:</b></br>");
            Response.Write("<ul>");
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    Response.Write("<li> " + item.Text + "</li>");
                }
            }
            Response.Write("</ul>");
            if (DropDownList1.SelectedItem != null)
            {
                Response.Write("<b>Selected items for dropDownList1:</b></br>");
                Response.Write("* " + DropDownList1.SelectedItem.Text + "<br/>");
            }

            Response.Write("<b>Selected items for CheckBoxList1:</b></br>");
            Response.Write("<ul>");
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    Response.Write("<li>" + item.Text + "</li>");
                }
            }
            Response.Write("</ul>");
            if (RadioButtonList1.SelectedItem != null)
            {
                Response.Write("<b>Selected items for radioButtonList1:</b></br>");
                Response.Write("* " + RadioButtonList1.SelectedItem.Text + "</br>");
            }
        }
    }
}