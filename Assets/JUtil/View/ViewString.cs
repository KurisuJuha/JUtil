using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewString
{
    private bool viewTypeName;
    private string typeName;

    private bool viewMain;
    private string main;

    public ViewString() { }

    public ViewString(string main, Type type)
    {
        SetMain();
        this.main = main;
        this.typeName = type.Name;
    }

    public ViewString SetTypeName()
    {
        viewTypeName = true;

        return this;
    }

    public ViewString SetMain()
    {
        viewMain = true;

        return this;
    }

    public override string ToString()
    {
        return this;
    }

    public static implicit operator string(ViewString viewString)
    {
        List<string> strs = new List<string>();

        if (viewString.viewTypeName)
        {
            string str = "typeName : ";
            str += viewString.typeName;
            strs.Add(str);
        }

        if (viewString.viewMain)
        {
            string str = "data : ";
            str += viewString.main;
            strs.Add(str);
        }

        return string.Join('\n', strs);
    }
}
