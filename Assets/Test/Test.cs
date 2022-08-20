using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JuhaKurisu.JUtil;

public class Test : MonoBehaviour
{
    void Start()
    {
        BytesUtilTest();
        ViewStringTest();
    }

    void Update()
    {
        
    }

    public void BytesUtilTest()
    {
        int a = 5;
        Debug.Log(a);
        byte[] b = a.GetBytes();
        Debug.Log(string.Join(',', b));
        int c = b.ToInt();
        Debug.Log(c);
    }

    public void ViewStringTest()
    {
        int a = 10;
        Debug.Log(a.View());

        string b = "hogehogefoo";
        Debug.Log(b.View());

        float c = Mathf.PI;
        Debug.Log(c.View());

        bool d = true;
        Debug.Log(d
            .View());

        int[] e = new int[]
        {
            1,
            2,
            3,
            4,
            5,
            6,
        };

        Debug.Log(e
            .View());

        string[] f = new string[]
        {
            "hoge",
            "ho-ge",
            "hogeho-ge",
            "ho-gehoge",
            "HoGeHoGe",
        };

        Debug.Log(f.View());

        List<int>[] g = new List<int>[]
        {
            new List<int>(),
        };

        Debug.Log(g
            .View());

        List<string> h = new List<string>()
        {
            "hoge",
            "ho-ge",
            "hogeho-ge",
            "ho-gehoge",
            "HoGeHoGe",
        };

        Debug.Log(h
            .View());
    }
}
