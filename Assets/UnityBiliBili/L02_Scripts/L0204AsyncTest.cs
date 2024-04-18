using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L0204AsyncTest : MonoBehaviour
{
    AsyncOperation operation;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadScene());
    }

    // 协程方法用来异步加载场景
    IEnumerator loadScene()
    {
        operation = SceneManager.LoadSceneAsync(1);
        yield return operation;
    }


    // Update is called once per frame
    void Update()
    {
        // 输出加载进度
        // Debug.Log(operation.progress);
        Debug.Log($"输出加载进度   : {operation.progress}");
    }
}
