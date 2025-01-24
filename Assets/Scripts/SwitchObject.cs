using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    public GameObject Globe;
    public GameObject Pot;
    public GameObject Scarpa;
    public GameObject Wheel;
    public GameObject Key;
    public GameObject Newspaper;
    public GameObject Book;
    public GameObject Hammer;
    private Vector3 p1;
    private Vector3 p2;
    private Vector3 p3;
    private Vector3 p4;
    private Vector3 p5;
    private Vector3 p6;
    private Vector3 p7;
    private Vector3 p8;
    private Quaternion q1;
    private Quaternion q2;
    private Quaternion q3;
    private Quaternion q4;
    private Quaternion q5;
    private Quaternion q6;
    private Quaternion q7;
    private Quaternion q8;

    void Start()
    {
        Application.targetFrameRate = 60;
        p1 = Globe.transform.position;
        p2 = Pot.transform.position;
        p3 = Scarpa.transform.position;
        p4 = Wheel.transform.position;
        p5 = Key.transform.position;
        p6 = Newspaper.transform.position;
        p7 = Book.transform.position;
        p8 = Hammer.transform.position;

        q1 = Globe.transform.rotation;
        q2 = Pot.transform.rotation;
        q3 = Scarpa.transform.rotation;
        q4 = Wheel.transform.rotation;
        q5 = Key.transform.rotation;
        q6 = Newspaper.transform.rotation;
        q7 = Book.transform.rotation;
        q8 = Hammer.transform.rotation;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Globe.transform.position = p1;
            Globe.transform.rotation = q1;
            Pot.transform.position = p2;
            Pot.transform.rotation = q2;
            Scarpa.transform.position = p3;
            Scarpa.transform.rotation = q3;
            Wheel.transform.position = p4;
            Wheel.transform.rotation = q4;
            Key.transform.position = p5;
            Key.transform.rotation = q5;
            Newspaper.transform.position = p6;
            Newspaper.transform.rotation = q6;
            Book.transform.position = p7;
            Book.transform.rotation = q7;
            Hammer.transform.position = p8;
            Hammer.transform.rotation = q8;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            InitObjects();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InitObjects();
            Debug.Log("Globe Detected");
            Globe.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            InitObjects();
            Debug.Log("Pot Detected");
            Pot.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            InitObjects();
            Debug.Log("Scarpa Detected");
            Scarpa.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            InitObjects();
            Debug.Log("Wheel Detected");
            Wheel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            InitObjects();
            Debug.Log("Key Detected");
            Key.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            InitObjects();
            Debug.Log("Newspaper Detected");
            Newspaper.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            InitObjects();
            Debug.Log("Book Detected");
            Book.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            InitObjects();
            Debug.Log("Hammer Detected");
            Hammer.SetActive(true);
        }
    }

    void InitObjects()
    {
        Globe.SetActive(false);
        Pot.SetActive(false);
        Scarpa.SetActive(false);
        Wheel.SetActive(false);
        Key.SetActive(false);
        Newspaper.SetActive(false);
        Book.SetActive(false);
        Hammer.SetActive(false);
    }
}
