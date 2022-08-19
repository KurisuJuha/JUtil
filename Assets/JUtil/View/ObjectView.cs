using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JUtil
{
    public static class ObjectView
    {
        public static ViewString View(this object obj)
        {
            return new ViewString(obj.ToString(), typeof(object));
        }

        public static ViewString View(this int value)
        {
            return new ViewString(value.ToString(), typeof(int));
        }

        public static ViewString View(this string value)
        {
            return new ViewString(value, typeof(string));
        }
    }
}