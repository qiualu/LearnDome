using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L6Axis_Key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 获取水平轴
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0.0 && vertical != 0.0) {
            Debug.Log($"horizontal : {horizontal}   vertical : {vertical} ");
        }

  

        // 虚拟按键
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log($"GetButtonDown Jump   按下  空格");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log($"GetButtonDown   Jump 持续按键");
        }
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log($"GetButtonDown Jump 抬起  空格");
        }



    }
}
