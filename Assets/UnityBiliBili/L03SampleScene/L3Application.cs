using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3Application : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��Ϸ�����ļ���·��
        Debug.Log(Application.dataPath + "/UnityBiliBili/L03SampleScene/�½��ı��ĵ�.txt");
        // �־û��ļ�·��
        Debug.Log(Application.persistentDataPath);
        // StreamingAssets�ļ���·��(ֻ��,����)
        Debug.Log(Application.streamingAssetsPath);
        // ��ʱ�ļ���
        Debug.Log(Application.temporaryCachePath);
        // �����Ƿ��ں�̨����
        Debug.Log(Application.runInBackground);
        // ��url
        Application.OpenURL("www.baidu.com");
        // �˳���Ϸ
        Application.Quit();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
