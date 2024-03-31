using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L03SceneTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ������,������,����������  // �����ļ�-> ��������� ��������
        //SceneManager.LoadScene(1);
        //��������
        Scene scene = SceneManager.GetActiveScene();
        //Debug.Log(scene.name);
        Debug.Log($" ��������   : {scene.name}");
        //�����Ƿ��Ѿ�����
        //Debug.Log(scene.isLoaded);
        Debug.Log($"�����Ƿ��Ѿ����� : {scene.isLoaded}");
        //����·��
        //Debug.Log(scene.path);
        Debug.Log($"����·�� : {scene.path}");
        //��������
        Debug.Log(scene.buildIndex);
        Debug.Log($"��������  : {scene.buildIndex}");
        GameObject[] gos = scene.GetRootGameObjects();
        //Debug.Log(gos.Length);
        Debug.Log($"������������  : {gos.Length}");

        // ����������

        // �����µĳ���
        Scene newScene = SceneManager.CreateScene("newScene");
        // �Ѽ��س�������
        Debug.Log(SceneManager.sceneCount);
        // ж�س���
        SceneManager.UnloadSceneAsync(newScene);
        // ���س���
        SceneManager.LoadScene("MyScene", LoadSceneMode.Additive);
        //SceneManager.LoadScene

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
