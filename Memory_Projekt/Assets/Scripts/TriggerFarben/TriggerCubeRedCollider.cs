using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeRedCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerRed")
        {
            Instantiate(prefab, new Vector3(-68.57f, 0, 4.98f), Quaternion.identity);
        }
    }
}
