using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class csTimeTest : MonoBehaviour
{
    GameObject obj;
    GameObject obj2;
    Text txt;
    Text txt2;
    System.DateTime ButtonClickTime;

    void Start ()
    {
        obj = GameObject.Find("Timetxt");
        obj2 = GameObject.Find("Timetxt2");
        txt = obj.GetComponent<Text>();
        txt2 = obj2.GetComponent<Text>();
    }
	

	void Update ()
    {
        txt.text = System.DateTime.Now.ToString("hh:mm:ss");
    }

    public void ButtonClick()
    {
        ButtonClickTime = System.DateTime.Now;
        txt2.text = ButtonClickTime.ToString("hh:mm:ss");
        
        
    }
}
