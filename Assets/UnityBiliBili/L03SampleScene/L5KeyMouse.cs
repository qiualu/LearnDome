using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5KeyMouse : MonoBehaviour
{

    int mindex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // ���ĵ��
        // ������� 0��� 1�Ҽ� 2����
        if (Input.GetMouseButtonDown(0))
        {
            mindex = 0;
            Debug.Log("���������� ");
        }
        // ��������������
        if (Input.GetMouseButton(0))
        {
            if (mindex < 1) {
                mindex = 1;
                Debug.Log("�������������� ");
            }

        }
        // ̧�����
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("̧�������� ");
        }

        // ���¼��̰���
        if(Input.GetKeyDown(KeyCode.A))
        {
            mindex = 0;
            Debug.Log("���¼���A�� ");
        }
        // �������¼��̰���
        if (Input.GetKey(KeyCode.A))
        {
            if (mindex < 1)
            {
                mindex = 1;
                Debug.Log("�������¼���A�� ");
            }
        }
        // ̧����̰���
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("̧�����A�� ");
        }


    }
}
