using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class L0203Empty : MonoBehaviour
{

    public GameObject Cube;
    // ��ȡԤ����
    public GameObject Prefab; 


    // Start is called before the first frame update
    void Start()
    {
        

        // �õ���ǰ�ű������ص���Ϸ����
        // GameObject go = this.gameObject;
        // ����
        Debug.Log(gameObject.name);
        // tag
        Debug.Log(gameObject.tag);
        // layer 
        Debug.Log(gameObject.layer);
        // �����������
        Debug.Log(Cube.name);
        //Debug.Log(Cube.active); // �Ƿ񼤻�
        //��ǰ�����ļ���״̬
        Debug.Log(Cube.activeInHierarchy); // �Ƿ񼤻�
        // �����Ƿ񼤻�״̬
        Debug.Log(Cube.activeSelf); // �Ƿ񼤻�
        // ��ȡ Transform���
        // Transform trans = this.transform;
        Debug.Log(transform.position);
        // ��ȡ�������
        BoxCollider bc = GetComponent<BoxCollider>();
        // ��ȡ��ǰ��������������ϵ�ĳ�����
        //GetComponentInParent<BoxCollider>();
        //GetComponentInParent<BoxCollider>();
        // ���һ�����
        //gameObject.AddComponent<AudioSource>();
        Cube.AddComponent<AudioSource>();

        // ͨ����Ϸ�������������ȡ��Ϸ����
        GameObject test = GameObject.Find("Test");
        Debug.Log(test.name);
        // ͨ����Ϸ��ǩ����ȡ��Ϸ����
        test = GameObject.FindWithTag("Enemy");
        Debug.Log(test.name);

        // ͨ��Ԥ������ʵ����һ����Ϸ���� Vector3(1.93, 1, 8.75)
        Instantiate(Prefab, Vector3.one, Quaternion.identity);
        // ����
        //Destroy(go);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
