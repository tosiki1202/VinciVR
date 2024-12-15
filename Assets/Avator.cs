using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class VRMap {

    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;


    public void Map()
    {
        rigTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);
    }


}

public class Avator : MonoBehaviour
{

    public VRMap head;
    public VRMap leftHand;
    public VRMap rightHand;

    public Transform headConstraint;
    public Vector3 headBodyOffest;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("最初の体の向き："+transform.forward);
        Debug.Log("最初のheadTarget:"+headConstraint.up);
        headConstraint.up=transform.forward;
        headBodyOffest = transform.position - headConstraint.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = headConstraint.position + headBodyOffest;
        transform.forward = Vector3.Lerp(transform.forward,Vector3.ProjectOnPlane(headConstraint.up,Vector3.up).normalized,Time.deltaTime*5);//*turnSmoothness
        Debug.Log("体の向き："+transform.forward);
        Debug.Log("headTarget:"+headConstraint.up);
        head.Map();
        leftHand.Map();
        rightHand.Map();
    }
}

