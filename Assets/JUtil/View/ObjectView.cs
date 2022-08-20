using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JUtil
{
    public static class ObjectView
    {
        public static string View<T>(this T obj)
        {
            return JsonUtility.ToJson(obj);
        }

        public static ViewString View(this int value)
        {
            return new ViewString(value.ToString(), typeof(int));
        }

        public static ViewString View(this string value)
        {
            return new ViewString("\"" + value + "\"", typeof(string));
        }

        public static ViewString View(this float value)
        {
            return new ViewString(value.ToString() + "f", typeof(float));
        }

        public static ViewString View(this bool value)
        {
            return new ViewString(value.ToString(), typeof(bool));
        }
    }
}
