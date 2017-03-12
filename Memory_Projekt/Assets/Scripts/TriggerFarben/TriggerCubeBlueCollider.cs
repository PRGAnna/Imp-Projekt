using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeBlueCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerBlue")
        {
            Instantiate(prefab, new Vector3(-68.57f, 1, 20.99f), Quaternion.identity);
        }
    }
}

