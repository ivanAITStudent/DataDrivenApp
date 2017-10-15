using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DDA_Ass02_v04;
using System.Collections.Specialized;

public partial class _Default : SharedData
{
    private ListDictionary pageStyle = new ListDictionary();    
    private string _ipaddress = "";
    private DateTime _sessionDate;

    protected void Page_Load(object sender, EventArgs e)
    {
        // set page style
        PageSetup();

        // set respondent type to Anonymus
        // this will change if the user logins in
        SessionController.SetRespondentType(1, "anonymus");

        // initialise session data
        _ipaddress = GetIPAddress();
        _sessionDate = DateTime.Now;

        // store details in Session 
        SessionController.setIP(_ipaddress);
        SessionController.setDateTime(_sessionDate);

        //debug
            List<string> stringsForLabel= new List<string>{ SessionController.getDateTime().ToLongDateString(),
                                                            ":",
                                                            SessionController.getDateTime().ToLongTimeString(),
                                                            "\n",
                                                            SessionController.getIP()};
            stringsForLabel.Add("\n");
            stringsForLabel.Add(SessionController.GetRespondentTypeID().ToString());
            stringsForLabel.Add(": ");
            stringsForLabel.Add(SessionController.GetRespondentTypeName());
            debug_lbl.Text = BuildString.Parse(stringsForLabel);
        //end debug
    }
    protected string GetIPAddress()
    {
        // get IP through PROXY
        // ====================
        System.Web.HttpContext context = System.Web.HttpContext.Current;
        string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        // break ipAddress down, but here is what it looks like:
        // return ipAddress;
        if (!string.IsNullOrEmpty(ipAddress))
        {
            string[] address = ipAddress.Split(',');
            if (address.Length != 0)
            {
                return address[0];
            }
        }
        //if not a proxy get user ip address

        ipAddress = context.Request.UserHostAddress; //or ServerVariables["REMOTE_ADDR"] both worked on non-proxy computer;

        if (ipAddress.Trim() == "::1")//ITS LOCAL(either lan or on same machine), CHECK LAN IP INSTEAD
        {
            //This is for Local(LAN) Connected ID Address
            string stringHostName = System.Net.Dns.GetHostName();

            //Get Ip Host Entry
            System.Net.IPHostEntry ipHostEntries = System.Net.Dns.GetHostEntry(stringHostName);

            //Get Ip Address From The Ip Host Entry Address List
            System.Net.IPAddress[] arrIpAddress = ipHostEntries.AddressList;

            // try to get the ip address from list
            // if it fails keep trying and if all fail defualt to ip address 127.0.0.1 
            try
            {
                ipAddress = arrIpAddress[1].ToString();
            }
            catch
            {
                try
                {
                    ipAddress = arrIpAddress[0].ToString();
                }
                catch
                {
                    try
                    {
                        arrIpAddress = System.Net.Dns.GetHostAddresses(stringHostName);
                        ipAddress = arrIpAddress[0].ToString();
                    }
                    catch
                    {
                        ipAddress = "127.0.0.1";
                    }
                }
            }
        }
        return ipAddress;
    } // end method

    private void PageSetup()
    {
        //get style data
        pageStyle.Add("ButtonWidth", SharedData._aspStyleSheet.buttonWidth);
        pageStyle.Add("FontSize", SharedData._aspStyleSheet.fontHeightSubTitle);
        pageStyle.Add("TitleFontSize", SharedData._aspStyleSheet.fontHeightTitle);

        //set title
        headerTitle_lbl.Font.Size = (int)pageStyle["TitleFontSize"];

        //set buttons
        //set button widths (SharedData._aspStyleSheet.buttonWidth)
        takeSurvey_btn.Width = (int)pageStyle["ButtonWidth"];
        login_btn.Width = (int)pageStyle["ButtonWidth"];
        register_btn.Width = (int)pageStyle["ButtonWidth"];

        //set button font size
        takeSurvey_btn.Font.Size = (int)pageStyle["FontSize"];
        login_btn.Font.Size = (int)pageStyle["FontSize"];
        register_btn.Font.Size = (int)pageStyle["FontSize"];
    }

    protected void takeSurvey_btn_Click(object sender, EventArgs e)
    {
        //open page
        Response.Redirect("TakeSurvey.aspx");

    }
}