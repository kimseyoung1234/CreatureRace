using UnityEngine;
using System.Collections;

public class csBombTest : MonoBehaviour
{
    public bool Bomb_Trigger = false;

    CarController obj;

    void Start()
    {
        obj = GameObject.Find("Car").GetComponent<CarController>();
    }

    void Update()
    {
        StartCoroutine(Bomb_Effect());
    }

    IEnumerator Bomb_Effect()
    {
        Debug.Log("BombTT1");
        if (Bomb_Trigger == true)
        {
            Debug.Log("BombTT2");

            obj.m_Topspeed = 0;

            yield return new WaitForSeconds(3.0f);

            BombEffect2();
        }
    }

    void BombEffect2()
    {
        Debug.Log("BombTT3");
        obj.m_Topspeed = 20;
    }

}
