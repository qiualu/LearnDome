using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L03_Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("awake");
    }

    private void OnEnable() // 激活组件的时候
    {
        Debug.Log("OnEnable");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
