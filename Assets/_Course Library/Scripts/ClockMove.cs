using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockMove : MonoBehaviour
{
    public GameObject clockHour;
    public GameObject clockMinute;
    public GameObject clockSecond;
    private DateTime dt;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        dt = DateTime.Now;
        float totalSeconds=dt.Hour*60*60+dt.Minute*60+dt.Second;
        clockHour.transform.localEulerAngles = new Vector3(90+(totalSeconds%(12*60*60)/120),0,-90); //43200段階で離散化
        clockMinute.transform.localEulerAngles = new Vector3(90+(totalSeconds%(60*60)/10),0,-90);
        clockSecond.transform.localEulerAngles = new Vector3(90+(dt.Second%60*6),0,-90);
    }
}
