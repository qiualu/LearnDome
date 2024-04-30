using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7Touch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ¿ªÆô¶àµã´¥¿Ø
        Input.multiTouchEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // ÅÐ¶Ïµ¥µã´¥Ãþ
        if (Input.touchCount == 1) {

            // ´¥¿Ø¶ÔÏó
            Touch touch = Input.touches[0];
            // ´¥ÃþÎ»ÖÃ
            Debug.Log($"  touch : {touch.position} ");
            //´¥Ãþ½×¶Î 
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

        // ÅÐ¶Ï¶àµã´¥Ãþ
        if (Input.touchCount == 2) {
            Touch touch = Input.touches[0];
            Touch touch2 = Input.touches[1];


        }


    }
}
