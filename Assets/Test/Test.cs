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
        Debug.Log(b.View().SetTypeName());

        float c = Mathf.PI;
        Debug.Log(c.View().SetTypeName());

        bool d = true;
        Debug.Log(d
            .View()
            .SetTypeName());
    }
}
