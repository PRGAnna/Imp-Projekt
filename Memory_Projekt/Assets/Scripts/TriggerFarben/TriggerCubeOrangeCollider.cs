using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeOrangeCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerOrange")
        {
            Instantiate(prefab, new Vector3(-68.57f, 3, 54.4f), Quaternion.identity);
        }
    }
}