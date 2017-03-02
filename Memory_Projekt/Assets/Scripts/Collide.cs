using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "trigger")
        {
            Instantiate(prefab, new Vector3(2.0f, 0, 0), Quaternion.identity);
        }
	}
}
