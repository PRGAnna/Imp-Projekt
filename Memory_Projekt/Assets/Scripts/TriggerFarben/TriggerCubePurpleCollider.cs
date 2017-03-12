using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubePurpleCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerPurple")
        {
            Instantiate(prefab, new Vector3(-68.57f, 4, 73.3f), Quaternion.identity);
        }
    }
}
