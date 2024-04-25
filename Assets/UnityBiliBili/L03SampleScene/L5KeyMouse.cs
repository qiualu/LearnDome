using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5KeyMouse : MonoBehaviour
{

    int mindex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 鼠标的点击
        // 按下鼠标 0左键 1右键 2滚轮
        if (Input.GetMouseButtonDown(0))
        {
            mindex = 0;
            Debug.Log("按下鼠标左键 ");
        }
        // 持续按下鼠标左键
        if (Input.GetMouseButton(0))
        {
            if (mindex < 1) {
                mindex = 1;
                Debug.Log("持续按下鼠标左键 ");
            }

        }
        // 抬起鼠标
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("抬起鼠标左键 ");
        }

        // 按下键盘按键
        if(Input.GetKeyDown(KeyCode.A))
        {
            mindex = 0;
            Debug.Log("按下键盘A键 ");
        }
        // 持续按下键盘按键
        if (Input.GetKey(KeyCode.A))
        {
            if (mindex < 1)
            {
                mindex = 1;
                Debug.Log("持续按下键盘A键 ");
            }
        }
        // 抬起键盘按键
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("抬起键盘A键 ");
        }


    }
}
