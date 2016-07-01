using UnityEngine;
using System.Collections;

public class csWaterTest : MonoBehaviour
{
    csCarSpeedTest WTile;
    csBombTest BTile;

    void Update()
    {
        CheckTile();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Water")
        {
            Debug.Log(" Water Collision ");
        }

        if (other.tag == "Jump_Area")
        {
            GameObject.Find("Car").GetComponent<Rigidbody>().AddForce(Vector3.up * 150000.0f);
            Debug.Log("Jump!");
        }
        if (other.tag == "Small_Jump_Area")
        {
            GameObject.Find("Car").GetComponent<Rigidbody>().AddForce(Vector3.up * 20000.0f);
            Debug.Log("Small_Jump!");
        }
        if (other.tag == "Bomb_Area")
        {

        }
    }


    void CheckTile()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, -transform.up, 1.0f);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            Debug.Log(hit.collider.gameObject.tag);

            if (hit.collider.gameObject.tag == "Water")
            {
                WTile = GameObject.Find("Main Camera").GetComponent<csCarSpeedTest>();
                WTile.WaterTile = true;
            }
            else if (hit.collider.gameObject.tag == "Untagged")
            {
                WTile = GameObject.Find("Main Camera").GetComponent<csCarSpeedTest>();
                WTile.WaterTile = false;
            }
            else if (hit.collider.gameObject.tag == "Bomb_Area")
            {
                BTile = GameObject.Find("Bomb_Area").GetComponent<csBombTest>();
                BTile.Bomb_Trigger = true;
            }
        }

        Debug.DrawRay((transform.position + new Vector3(0, 1.0f, 0)), -transform.up * 1, Color.red);  

    }

}
