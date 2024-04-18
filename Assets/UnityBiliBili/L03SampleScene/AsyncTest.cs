using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

// 添加包
using UnityEngine.SceneManagement;

public class AsyncTest : MonoBehaviour
{
    AsyncOperation operation;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(loadSceneAuto());
        StartCoroutine(loadScene());
    }

    // 协程方法用来异步加载场景
    IEnumerator loadSceneAuto()
    {
        operation = SceneManager.LoadSceneAsync(1);
        yield return operation;
    }

    // 协程方法用来异步加载场景
    IEnumerator loadScene()
    {
        operation = SceneManager.LoadSceneAsync(1);
        // 加载完成场景不要自动跳转
        operation.allowSceneActivation = false;
        yield return operation;
    }

    float time = 0;

    // Update is called once per frame
    void Update()
    {
        // 输出加载进度
        // Debug.Log(operation.progress);
        Debug.Log($"输出加载进度   : {operation.progress}   {time} ");

        time += Time.deltaTime;
        // 达到5秒，再自动跳转
        if (time > 5)
        {
            operation.allowSceneActivation = true;
        }


    }
}


//  TDMovieOut.0.jpg
// docker run -v path/to/input:/ rembg danielgatis / rembg i TDMovieOut.0.jpg output.png
