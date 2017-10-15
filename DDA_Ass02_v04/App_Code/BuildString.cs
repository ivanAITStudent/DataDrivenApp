using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BuildString
/// </summary>
public static class BuildString
{
    public static string Parse(List<string> listOfStrings)
    {
        string str = "";
        foreach (string s in listOfStrings)
        {
            str += s;
        }
        return str;
    }
}