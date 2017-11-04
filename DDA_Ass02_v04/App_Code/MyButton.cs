using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public class MyButton: Button
{
    private int storedID;
    private string buttonText;
    
    public MyButton(int storedID, string buttonTitle, bool enabled)
    {
        StoredID = storedID;
        ButtonText = buttonTitle;
        this.ID = buttonTitle + "_btn";
        this.Text = ButtonText;
        this.Attributes.Add("class", "btn btn-primary btn-lg myButton");
        this.Attributes.Add("runat", "server");
        this.Enabled = enabled;
        //this.Click += new EventHandler(button_Click);
    }

    public int StoredID
    {
        get
        {
            return storedID;
        }

        set
        {
            storedID = value;
        }
    }

        public string ButtonText
    {
        get
        {
            return buttonText;
        }

        set
        {
            buttonText = value;
        }
    }


    public void changeAttribute(string attribute, string value)
    {
        this.Attributes.Add(attribute, value);
    }
}

