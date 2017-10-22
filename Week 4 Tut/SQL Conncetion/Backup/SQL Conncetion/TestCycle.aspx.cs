using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQL_Conncetion
{
    public partial class TestCycle : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit<br/>");
            //programatically adding event listeners to button
            Button1.Init += new EventHandler(this.Button_Init);
            Button1.PreRender += new EventHandler(this.Button_PreRender);
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRenderComplete<br/>");
        }

        protected void Button1_Load(object sender, EventArgs e)
        {
            Response.Write("Button Load<br/>");
        }

        protected void Button_Init(object sender, EventArgs e)
        {
            Response.Write("Button init<br/>");
        }
        protected void Button_PreRender(object sender, EventArgs e)
        {
            Response.Write("Button pre render<br/>");
        }
    }
}