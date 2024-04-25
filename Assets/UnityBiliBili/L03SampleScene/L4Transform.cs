using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4Transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 获取位置 
        Debug.Log($"获取位置 position : {transform.position}");
        Debug.Log($"获取位置 localPosition  : {transform.localPosition}");
        // 获取旋转 
        Debug.Log($"获取旋转 rotation  : {transform.rotation}");
        Debug.Log($"获取旋转 localRotation  : {transform.localRotation}");
        Debug.Log($"获取旋转 eulerAngles  : {transform.eulerAngles}");
        Debug.Log($"获取旋转 localEulerAngles  : {transform.localEulerAngles}");
        // 获取缩放 
        Debug.Log($"获取缩放 localScale  : {transform.localScale}");
        // 向量
        Debug.Log($"向量 forward  : {transform.forward}");
        Debug.Log($"向量 right  : {transform.right}");
        Debug.Log($"向量 up  : {transform.up}");

        // 父子关系
        // 获取父物体
        //transform.parent.gameObject
        // 子个体个数
        Debug.Log($"子个体个数 up  : {transform.childCount}");
        // 解除 与 子物体的父子关系
        //transform.DetachChildren();
        // 获取子物体
        Transform trans = transform.Find("Child");
        trans = transform.GetChild(0);
        //判断一个物体是不是另一个物体的子物体
        bool res = trans.IsChildOf(transform);
        Debug.Log($"res   : {res}");
        //设置 为父物体
        trans.SetParent(transform);


    }

    // Update is called once per frame
    void Update()
    {
        // 时时刻刻看向000点
        //transform.LookAt(Vector3.zero);
        // 旋转 
        //transform.Rotate(Vector3.up, 1);
        // 绕着某个物体旋转
        //transform.RotateAround(Vector3.zero, Vector3.up, 1);
        
        // 子物体旋转
        Transform trans = transform.Find("Child2");
        trans = transform.GetChild(0);
        trans.Rotate(Vector3.up, 1);
        //trans.RotateAround(Vector3.zero, Vector3.up, 1);
        // 移动
        //transform.Translate(Vector3.forward * Time.deltaTime * 0.1f);

    }
}
