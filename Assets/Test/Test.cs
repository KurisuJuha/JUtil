using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JuhaKurisu.JUtil;

public class Test : MonoBehaviour
{
    void Start()
    {
        BytesUtilTest();
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
}
