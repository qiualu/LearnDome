using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L0203Empty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        // 拿到当前脚本所挂载的游戏物体
        // GameObject go = this.gameObject;
        // 名称
        Debug.Log(gameObject.name);
        // tag
        Debug.Log(gameObject.tag);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
