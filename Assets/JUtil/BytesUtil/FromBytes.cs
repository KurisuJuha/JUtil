using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JUtil
{
    public static class FromBytesUtil
    {
        public static int ToInt(this byte[] value)
        {
            return BitConverter.ToInt32(value, 0);
        }

        public static float ToFloat(this byte[] value)
        {
            return BitConverter.ToSingle(value, 0);
        }

        public static string ToString(this byte[] value)
        {
            return Encoding.UTF8.GetString(value);
        }

        public static char ToChar(this byte[] value)
        {
            return BitConverter.ToChar(value);
        }

        public static bool ToBool(this byte[] value)
        {
            return BitConverter.ToBoolean(value);
        }
    }
}