﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3Application : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 游戏数据文件夹路径
        Debug.Log(Application.dataPath + "/UnityBiliBili/L03SampleScene/说明文档.txt");
        // 持久化文件路径
        Debug.Log(Application.persistentDataPath);
        // StreamingAssets文件夹路径(只读,配置)
        Debug.Log(Application.streamingAssetsPath);
        // 临时文件夹
        Debug.Log(Application.temporaryCachePath);
        // 控制是否在后台运行
        Debug.Log(Application.runInBackground);
        // 打开url
        Application.OpenURL("www.baidu.com");
        // 退出游戏
        Application.Quit();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
