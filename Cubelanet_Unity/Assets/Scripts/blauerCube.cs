using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blauerCube : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "TriggerBlue")
        {
            Instantiate(prefab, new Vector3(-7.2f, 1, 3.1f), Quaternion.identity);
        }
    }
}
