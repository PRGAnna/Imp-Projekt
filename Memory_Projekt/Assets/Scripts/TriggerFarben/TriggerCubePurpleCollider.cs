using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubePurpleCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerPurple")
        {
            Instantiate(prefab, new Vector3(-109.4f, 4, 105.2f), Quaternion.identity);
        }
    }
}
