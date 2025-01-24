using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatorAjuster : MonoBehaviour
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
            
            // 1.8m=アバターの身長
            Avator.transform.localScale = new Vector3(Avator.transform.localScale.x*Camera.transform.localPosition.y/1.8f,
                                                      Avator.transform.localScale.y*Camera.transform.localPosition.y/1.8f,
                                                      Avator.transform.localScale.z);

            Debug.Log("アバタースケール:"+Camera.transform.localPosition.y/1.7f);
            Debug.Log("修正後のディスプレイの高さ:"+Camera.transform.localPosition.y);
        }
    }
}
