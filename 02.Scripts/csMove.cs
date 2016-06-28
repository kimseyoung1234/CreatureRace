using UnityEngine;
using System.Collections;

public class csMove : MonoBehaviour {


    float speed = 25.0f;
    float rotateSpeed = 50.0f;
    float v;
    public Transform target;

    bool Trigger = true;

    Transform mTrans;
    // Use this for initialization
    void Start () {
        mTrans = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            Vector3 dir = target.position - mTrans.position;
            float mag = dir.magnitude;

            if (mag > 0.001f)
            {
                Quaternion lookRot = Quaternion.LookRotation(dir);
                mTrans.rotation = Quaternion.Slerp(mTrans.rotation, lookRot, Mathf.Clamp01(speed * Time.deltaTime));
            }
        }

        Debug.Log("이동");
        v = v * speed * Time.deltaTime;
        // transform.Translate(Vector3.forward * v);
        if (Trigger)
        GetComponent<Rigidbody>().AddForce(transform.TransformVector(0.0f, 0.0f, 1.0f) * 13);
    }

    public void ButtonClick()
    {
        Trigger = false;
       // GetComponent<Rigidbody>().AddForce(transform.TransformVector(0.0f, 0.0f, 1.0f) * 0);
    }

   

}
