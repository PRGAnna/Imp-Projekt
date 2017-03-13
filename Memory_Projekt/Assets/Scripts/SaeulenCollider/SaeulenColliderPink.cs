using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderPink : MonoBehaviour {



	public GameObject pinkSaeule;
	public GameObject prefab;
	public Color32 color32 = new Color32(236, 99, 204, 255);

	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "SaeulePink")
		{
			pinkSaeule = GameObject.FindWithTag ("SaeulePink");
			pinkSaeule.GetComponent<Renderer>().material.color = color32;
			Instantiate(prefab, new Vector3(-46.565f, 2, -23.32f), Quaternion.identity);
		}
	}
}