﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L0202DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        Debug.LogWarning("test2");
        Debug.LogError("Test3");
    }

    // Update is called once per frame
    void Update()
    {
        // 绘制一条线
        Debug.DrawLine(Vector3.zero, Vector3.one);
    }
}
