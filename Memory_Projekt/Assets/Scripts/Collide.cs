using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

    public GameObject prefab;

    void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "trigger")
        {
            Instantiate(prefab, new Vector3(-36.2f, 5, 25.5f), Quaternion.identity);
        }
	}
}
