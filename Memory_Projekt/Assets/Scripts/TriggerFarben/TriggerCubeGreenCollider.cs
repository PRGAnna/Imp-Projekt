using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeGreenCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerGreen")
        {
            Instantiate(prefab, new Vector3(-72.8f, 2, 49), Quaternion.identity);
        }
    }
}
