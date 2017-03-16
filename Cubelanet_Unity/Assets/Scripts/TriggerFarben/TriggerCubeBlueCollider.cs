using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeBlueCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerBlue")
        {
            Instantiate(prefab, new Vector3(-63.5f, 1, 27.6f), Quaternion.identity);
        }
    }
}

