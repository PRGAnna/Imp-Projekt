using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeGreenCollider : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerGreen")
        {
            Instantiate(prefab, new Vector3(-68.57f, 2, 37.6f), Quaternion.identity);
        }
    }
}
