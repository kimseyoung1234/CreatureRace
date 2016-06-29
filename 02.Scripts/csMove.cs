using UnityEngine;
using System.Collections;

public class csMove : MonoBehaviour {


    float speed = 13.0f;

    public Transform target;

    bool Trigger = true;

    Transform mTrans;
    // Use this for initialization
    void Start () {
      //  mTrans = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            float mag = dir.magnitude;

            if (mag > 0.001f)
            {
                Quaternion lookRot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Mathf.Clamp01(25 * Time.deltaTime));
            }
        }
        if (Trigger)
        GetComponent<Rigidbody>().AddForce(transform.TransformVector(0.0f, 0.0f, 1.0f) * speed);
    }

    public void ButtonClick()
    {
        Trigger = false;
  
    }

   

}
