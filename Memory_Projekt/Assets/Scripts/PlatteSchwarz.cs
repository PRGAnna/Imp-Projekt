using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatteSchwarz : MonoBehaviour {

	public GameObject prefab;


	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "platteSchwarz")
		{
			Application.LoadLevel ("034_Menu");
		}
	}
}