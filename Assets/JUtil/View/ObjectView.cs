using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JUtil
{
    public static class ObjectView
    {
        public static ViewString View(this object obj)
        {
            if (obj is int)
            {
                return ((int)obj).View();
            }
            if (obj is string)
            {
                return ((string)obj).View();
            }
            if (obj is float)
            {
                return ((float)obj).View();
            }
            if (obj is bool)
            {
                return ((bool)obj).View();
            }

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

        public static ViewString View<T>(this T[] value)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(" [ ");
            
            for (int i = 0; i < value.Length; i++)
            {
                builder.Append(value[i].View());

                if (i != value.Length - 1)
                {
                    builder.Append(" , ");
                }
            }

            builder.Append(" ] ");

            return new ViewString(builder.ToString(), typeof(T[]));
        }

        public static ViewString View<T>(this List<T> value)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(" [ ");

            for (int i = 0; i < value.Count; i++)
            {
                builder.Append(value[i].View());

                if (i != value.Count - 1)
                {
                    builder.Append(" , ");
                }
            }

            builder.Append(" ] ");

            return new ViewString(builder.ToString(), typeof(List<T>));
        }
    }
}
