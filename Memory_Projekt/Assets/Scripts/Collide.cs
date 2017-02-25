using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	
	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "trigger")
        { Destroy(col.gameObject);
        }
	}
}
