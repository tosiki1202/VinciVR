using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSAvatorAjuster : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Avator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("キャリブレーションを行います");
            Debug.Log("ディスプレイの高さ："+Camera.transform.localPosition.y);

            Vector3 tf_camera = new Vector3(Camera.transform.localPosition.x,
                                            Camera.transform.localPosition.y,
                                            Camera.transform.localPosition.z);
            
            // 1.66=vinci直立時のheadの位置
            Avator.transform.localScale = new Vector3(Avator.transform.localScale.x*Camera.transform.localPosition.y/1.58f,
                                                      Avator.transform.localScale.y*Camera.transform.localPosition.y/1.58f,
                                                      Avator.transform.localScale.z);

            Debug.Log("アバタースケール:"+Camera.transform.localPosition.y/1.58f);
            Debug.Log("修正後のディスプレイの高さ:"+Camera.transform.localPosition.y);
        }
    }
}
