using UnityEngine;
using System.Collections;

public class csCarSpeedTest : MonoBehaviour
{
    CarController obj;
    CarAIControl aa;
    public bool WaterTile = false;

    void Start()
    {
        obj = GameObject.Find("Car").GetComponent<CarController>();
      //  aa = GameObject.Find("Car").GetComponent<CarAIControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WaterTile == false)
        {
            Debug.Log("평지를달리는중");
            obj.m_Topspeed = 20;
        }
        else if (WaterTile == true)
        {
            Debug.Log("물속을달리는중");
            obj.m_Topspeed = 10;
        }
    }

    public void ButtonClick()
    {
      //  Rigidbody body = GameObject.Find("Car").GetComponent<Rigidbody>();
       // body.velocity = body.velocity * 2;
        obj.m_Topspeed = 30;
      //  aa.m_Driving = true;
    }

    public void velocityButton()
    {
        obj.m_Topspeed = 0;
        /*
        Rigidbody body = GameObject.Find("Car").GetComponent<Rigidbody>();
        body.velocity = Vector3.zero;
        aa = GameObject.Find("Car").GetComponent<CarAIControl>();
        */
      //  aa.m_Driving = false;
        
    }

    public void jumpButton()
    {
        GameObject.Find("Car").GetComponent<Rigidbody>().AddForce(Vector3.up * 150000.0f);
    }
}