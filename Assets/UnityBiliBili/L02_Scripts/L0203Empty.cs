using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class L0203Empty : MonoBehaviour
{

    public GameObject Cube;
    // 获取预设体
    public GameObject Prefab;


    // Start is called before the first frame update
    void Start()
    {


        // 拿到当前脚本所挂载的游戏物体
        // GameObject go = this.gameObject;
        // 名称
        Debug.Log(gameObject.name);
        // tag
        Debug.Log(gameObject.tag);
        // layer 
        Debug.Log(gameObject.layer);
        // 立方体的名称
        Debug.Log(Cube.name);
        //Debug.Log(Cube.active); // 是否激活
        //当前真正的激活状态
        Debug.Log(Cube.activeInHierarchy); // 是否激活
        // 本身是否激活状态
        Debug.Log(Cube.activeSelf); // 是否激活
        // 获取 Transform组件
        // Transform trans = this.transform;
        Debug.Log(transform.position);
        // 获取其他组件
        BoxCollider bc = GetComponent<BoxCollider>();
        // 获取当前物体的子物体身上的某个组件
        //GetComponentInParent<BoxCollider>();
        //GetComponentInParent<BoxCollider>();
        // 添加一个组件
        //gameObject.AddComponent<AudioSource>();
        Cube.AddComponent<AudioSource>();

        // 通过游戏物体的名称来获取游戏物体
        GameObject test = GameObject.Find("Test");
        Debug.Log(test.name);
        // 通过游戏标签来获取游戏物体
        test = GameObject.FindWithTag("Enemy");
        Debug.Log(test.name);

        // 通过预设体来实例化一个游戏对象 Vector3(1.93, 1, 8.75)
        Instantiate(Prefab, Vector3.one, Quaternion.identity);
        // 销毁
        //Destroy(go);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
