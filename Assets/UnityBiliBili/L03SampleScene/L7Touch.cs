using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7Touch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ������㴥��
        Input.multiTouchEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // �жϵ��㴥��
        if (Input.touchCount == 1) {

            // ���ض���
            Touch touch = Input.touches[0];
            // ����λ��
            Debug.Log($"  touch : {touch.position} ");
            //�����׶� 
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Stationary: break;
                case TouchPhase.Ended: break;
                case TouchPhase.Canceled: break;
            }
        }

        // �ж϶�㴥��
        if (Input.touchCount == 2) {
            Touch touch = Input.touches[0];
            Touch touch2 = Input.touches[1];


        }


    }
}
