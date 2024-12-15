using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellingFanMove : MonoBehaviour
{
    [SerializeField] private float BLADESPEED;
    public GameObject blade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blade.transform.localEulerAngles = new Vector3(blade.transform.localEulerAngles.x,blade.transform.localEulerAngles.y+BLADESPEED,blade.transform.localEulerAngles.z);
    }
}
