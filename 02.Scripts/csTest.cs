using UnityEngine;
using System.Collections;

public class csTest : MonoBehaviour
{
    public GameObject clone;
    public GameObject parent;

    int nName = 0;
    Transform[] SpawnObject;

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 80, 50), "Add One"))
        {
            GameObject goTemp = Instantiate(clone, Vector3.zero, Quaternion.identity) as GameObject;
            goTemp.transform.parent = parent.transform;
            goTemp.name = "child_" + nName;
            nName++;
        }

        if (GUI.Button(new Rect(10, 80, 80, 50), "Delete All"))
        {
            SpawnObject = GameObject.Find("Parent").GetComponentsInChildren<Transform>();

            for (int i = 1; i < SpawnObject.Length; i++)
            {
                Destroy(SpawnObject[i].gameObject);
                nName = 0;
            }
        }
    }
}
