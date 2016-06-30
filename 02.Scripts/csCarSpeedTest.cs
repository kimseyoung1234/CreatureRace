using UnityEngine;
using System.Collections;

public class csCarSpeedTest : MonoBehaviour
{

    CarController obj;
    // Use this for initialization
    void Start()
    {

        obj = GameObject.Find("Car").GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClick()
    {

        obj.m_Topspeed = 150;
    

    }
}