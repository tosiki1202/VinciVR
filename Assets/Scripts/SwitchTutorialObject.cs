using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTutorialObject : MonoBehaviour
{
    public GameObject Tennis;
    private Vector3 p1;
    private Quaternion q1;

    void Start()
    {
        Application.targetFrameRate = 60;
        p1 = Tennis.transform.position;

        q1 = Tennis.transform.rotation;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Tennis.transform.position = p1;
            Tennis.transform.rotation = q1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            InitObjects();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InitObjects();
            Debug.Log("Tennis Detected");
            Tennis.SetActive(true);
        }
    }

    void InitObjects()
    {
        Tennis.SetActive(false);
    }
}
