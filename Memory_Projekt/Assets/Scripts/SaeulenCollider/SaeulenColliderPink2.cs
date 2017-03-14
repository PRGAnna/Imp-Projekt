using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderPink2 : MonoBehaviour {

    public GameObject prefab;
    public Color32 color32 = new Color32(236, 99, 204, 255);
	public GameObject pinkSaeule2;


void OnCollisionEnter (Collision col) {
	if(col.gameObject.name == "SaeulePink2")
	{
		pinkSaeule2 = GameObject.FindWithTag("SaeulePink2");
		pinkSaeule2.GetComponent<Renderer>().material.color = color32;
		Instantiate(prefab, new Vector3(-98.6f, 2, -10.97f), Quaternion.identity);
	}
}
}