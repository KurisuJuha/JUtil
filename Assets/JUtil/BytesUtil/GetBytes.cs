using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GetBytesUtil
{
    public static byte[] GetBytes(this int value)
    {
        return BitConverter.GetBytes(value);
    }

    public static byte[] GetBytes(this float value)
    {
        return BitConverter.GetBytes(value);
    }

    public static byte[] GetBytes(this string value)
    {
        return Encoding.UTF8.GetBytes(value);
    }

    public static byte[] GetBytes(this char value)
    {
        return BitConverter.GetBytes(value);
    }

    public static byte[] GetBytes(this bool value)
    {
        return BitConverter.GetBytes(value);
    }
}
