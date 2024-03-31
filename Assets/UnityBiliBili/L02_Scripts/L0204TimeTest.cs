using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L0204TimeTest : MonoBehaviour
{

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 游戏开始到现在的所花的时间
        Debug.Log(Time.time);
        // 时间缩放值
        Debug.Log(Time.timeScale);
        // 固定时间间隔
        Debug.Log(Time.fixedDeltaTime);
        // 上一帧到这一帧所用的游戏时间
        Debug.Log(Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // 上一帧到这一帧所用的游戏时间
        //Debug.Log(Time.deltaTime);
        timer += Time.deltaTime;
        if (timer > 3) {
            Debug.Log("timer > 3 ");
            timer = 0;
        }
    }

    private void FixedUpdate()
    {
        
    }


}
