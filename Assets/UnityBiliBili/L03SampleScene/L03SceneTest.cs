using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L03SceneTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 两个类,场景类,场景管理类  // 先在文件-> 构建中添加 构建场景
        //SceneManager.LoadScene(1);
        //场景名称
        Scene scene = SceneManager.GetActiveScene();
        //Debug.Log(scene.name);
        Debug.Log($" 场景名称   : {scene.name}");
        //场景是否已经加载
        //Debug.Log(scene.isLoaded);
        Debug.Log($"场景是否已经加载 : {scene.isLoaded}");
        //场景路径
        //Debug.Log(scene.path);
        Debug.Log($"场景路径 : {scene.path}");
        //场景索引
        Debug.Log(scene.buildIndex);
        Debug.Log($"场景索引  : {scene.buildIndex}");
        GameObject[] gos = scene.GetRootGameObjects();
        //Debug.Log(gos.Length);
        Debug.Log($"场景索引长度  : {gos.Length}");

        // 场景管理类

        // 创建新的场景
        Scene newScene = SceneManager.CreateScene("newScene");
        // 已加载场景个数
        Debug.Log(SceneManager.sceneCount);
        // 卸载场景
        SceneManager.UnloadSceneAsync(newScene);
        // 加载场景
        SceneManager.LoadScene("MyScene", LoadSceneMode.Additive);
        //SceneManager.LoadScene

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
