using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for SharedData
/// </summary>
public class SharedData : Page
{
    protected static ASPStyleSheet _aspStyleSheet = new ASPStyleSheet();
    protected ListDictionary listOfModels = new ListDictionary();

    public SharedData()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    //public ASPStyleSheet AspStyleSheet
    //{
    //    get
    //    {
    //        return _aspStyleSheet;
    //    }

    //    set
    //    {
    //        _aspStyleSheet = value;
    //    }
    //}

}