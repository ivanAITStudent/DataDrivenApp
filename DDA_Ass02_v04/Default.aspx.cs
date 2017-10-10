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
    private ListDictionary ps = new ListDictionary();

    protected void Page_Load(object sender, EventArgs e)
    {
        //initialise session model
        string _ipaddress = GetIPAddress();
        DateTime _sessionDate = DateTime.Now;

        // store details in Session 
        SessionController.setIP(_ipaddress);
        SessionController.setDateTime(_sessionDate);

        //get style data
        ps.Add("ButtonWidth", SharedData._aspStyleSheet.buttonWidth);
        ps.Add("FontSize", SharedData._aspStyleSheet.fontHeightSubTitle);
        ps.Add("TitleFontSize", SharedData._aspStyleSheet.fontHeightTitle);

        //set title
        headerTitle_lbl.Font.Size = (int)ps["TitleFontSize"];

        //set buttons
        //set button widths (SharedData._aspStyleSheet.buttonWidth)
        takeSurvey_btn.Width = (int)ps["ButtonWidth"];
        login_btn.Width = (int)ps["ButtonWidth"];
        register_btn.Width = (int)ps["ButtonWidth"];

        //set button font size
        takeSurvey_btn.Font.Size = (int)ps["FontSize"];
        login_btn.Font.Size = (int)ps["FontSize"];
        register_btn.Font.Size = (int)ps["FontSize"];


        //debug
        debug_lbl.Text = SessionController.getDateTime().ToLongDateString() + ":" + SessionController.getDateTime().ToLongTimeString();
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
        //if not proxy, get nice ip, give that back :(
        //ACROSS WEB HTTP REQUEST
        //=======================
        ipAddress = context.Request.UserHostAddress;//ServerVariables["REMOTE_ADDR"];

        if (ipAddress.Trim() == "::1")//ITS LOCAL(either lan or on same machine), CHECK LAN IP INSTEAD
        {
            //This is for Local(LAN) Connected ID Address
            string stringHostName = System.Net.Dns.GetHostName();
            //Get Ip Host Entry
            System.Net.IPHostEntry ipHostEntries = System.Net.Dns.GetHostEntry(stringHostName);
            //Get Ip Address From The Ip Host Entry Address List
            System.Net.IPAddress[] arrIpAddress = ipHostEntries.AddressList;

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
    }


    protected void takeSurvey_btn_Click(object sender, EventArgs e)
    {
        // save session model
    }
}