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
        StringBuilder builder = new StringBuilder();

        if (viewString.viewTypeName)
        {
            builder.Append("typeName : ");
            builder.Append(viewString.typeName);
            builder.AppendLine();
        }

        if (viewString.viewMain)
        {
            builder.Append("data : ");
            builder.Append(viewString.main);
            builder.AppendLine();
        }

        return builder.ToString();
    }
}
