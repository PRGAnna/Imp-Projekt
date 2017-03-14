using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeBlueCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerBlue")
        {
            Instantiate(prefab, new Vector3(-70.262f, 2, -50.4f), Quaternion.identity);
        }
    }
}

