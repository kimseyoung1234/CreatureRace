using UnityEngine;
using System.Collections;

public class csCarSpeedTest : MonoBehaviour
{

    CarController obj;
    CarAIControl aa;
    // Use this for initialization
    void Start()
    {

        obj = GameObject.Find("Car").GetComponent<CarController>();
      //  aa = GameObject.Find("Car").GetComponent<CarAIControl>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClick()
    {

      //  Rigidbody body = GameObject.Find("Car").GetComponent<Rigidbody>();
       // body.velocity = body.velocity * 2;
        obj.m_Topspeed = 20;
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
        Debug.Log("점프");
       GameObject.Find("Car").GetComponent<Rigidbody>().AddForce(Vector3.up * 500.0f);
       

        

    }
}