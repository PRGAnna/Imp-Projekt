using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLetztes : MonoBehaviour {

	//public GameObject triggerRaetsel;
	public GameObject prefab;


	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "TriggerLetztesRaetsel")
		{
			Instantiate(prefab, new Vector3(-128.31f, 4, 187), Quaternion.identity);
		}
	}
}