using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderGelb : MonoBehaviour {



	/*public GameObject yellowSaeule;
	public GameObject prefab;
	public Color32 color32 = new Color32(0, 255, 255, 7);

	void OnCollisionEnter (Collision col) 
	{
		if(col.gameObject.name == "SaeuleGelb")
		{
			yellowSaeule = GameObject.FindWithTag("SaeuleGelb");
			yellowSaeule.GetComponent<Renderer>().material.color = color32;
			Instantiate(prefab, new Vector3(-59.31f, 2, -22.5f), Quaternion.identity);
		}
	}
	}*/

public GameObject yellowSaeule;
public GameObject prefab;
public Color32 color32 = new Color32(255, 255, 7, 255);

void OnCollisionEnter (Collision col) {
	if(col.gameObject.name == "SaeuleGelb")
	{
			yellowSaeule = GameObject.FindWithTag ("SaeuleGelb");
		yellowSaeule.GetComponent<Renderer>().material.color = color32;
		Instantiate(prefab, new Vector3(-46.565f, 2, -23.32f), Quaternion.identity);
	}
}
}