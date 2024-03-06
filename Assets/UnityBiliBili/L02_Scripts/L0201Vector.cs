﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L0201Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v = new Vector3(1, 1, 0.5f);
        //v = Vector3.zero; // Vector3(0.0,0.0,0.0);
        //v = Vector3.one;  // Vector3(1.0,1.0,1.0);
        v = Vector3.right;  // Vector3(0.0,0.0,0.0);
        //v.x = 2.0f;
        Vector3 v2 = Vector3.forward; // Vector3(0.0,0.0,1.0);

        Debug.Log($"Vector3 v : {v}");
        Debug.Log($"Vector3 v2: {v2}");

        // 计算两个向量的夹角
        Debug.Log(Vector3.Angle(v, v2));
        // 计算两点之间的距离
        Debug.Log(Vector3.Distance(v, v2));
        // 点乘
        Debug.Log(Vector3.Dot(v, v2));
        // 插值
        Debug.Log(Vector3.Lerp(Vector3.zero, Vector3.one, 0.5f));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
