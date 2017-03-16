using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeOrangeCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerOrange")
        {
            Instantiate(prefab, new Vector3(-88.1f, 3, 73.8f), Quaternion.identity);
        }
    }
}