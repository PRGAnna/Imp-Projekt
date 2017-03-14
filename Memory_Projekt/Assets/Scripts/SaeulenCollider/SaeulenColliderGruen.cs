using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderGruen : MonoBehaviour {


    
    public Color32 color32 = new Color32(0, 255, 70, 255);

	public GameObject greenSaeule;
	public GameObject prefab;


	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "SaeuleGruen")
		{
			greenSaeule = GameObject.FindWithTag("SaeuleGruen");
				greenSaeule.GetComponent<Renderer>().material.color = color32;
				Instantiate(prefab, new Vector3(-113.338f, 2, -0.5f), Quaternion.identity);
				}
				}
				}
