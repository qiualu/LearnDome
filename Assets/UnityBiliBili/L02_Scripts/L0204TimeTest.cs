using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L0204TimeTest : MonoBehaviour
{

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        // ��Ϸ��ʼ�����ڵ�������ʱ��
        Debug.Log(Time.time);
        // ʱ������ֵ
        Debug.Log(Time.timeScale);
        // �̶�ʱ����
        Debug.Log(Time.fixedDeltaTime);
        // ��һ֡����һ֡���õ���Ϸʱ��
        Debug.Log(Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // ��һ֡����һ֡���õ���Ϸʱ��
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
