using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JUtil
{
    public static class ObjectView
    {
        public static void test(int value)
        {
            Debug.Log("int‚Å‚µ‚½");
        }
        public static void test(object value)
        {
            Debug.Log("object‚Å‚µ‚½");
        }

        public static ViewString View<T>(this T obj)
        {
            return new ViewString(obj.ToString(), typeof(object));
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
