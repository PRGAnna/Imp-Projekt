using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenCollider : MonoBehaviour {
    
	/*
    //public GameObject blueSaeule;
    public Color32 color32 = new Color32(0, 255, 255, 255);
   
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "SaeuleBlau")
        {
            blueSaeule = GameObject.FindWithTag("SaeuleBlau");
			gameObject.GetComponent<Renderer>().material.color = color32;


        }
    }
}*/

public GameObject blueSaeule;
public GameObject prefab;
public Color32 color32 = new Color32(0, 255, 255, 255);

void OnCollisionEnter (Collision col) {
	if(col.gameObject.name == "SaeuleBlau")
	{
		blueSaeule = GameObject.FindWithTag("SaeuleBlau");
		blueSaeule.GetComponent<Renderer>().material.color = color32;
		Instantiate(prefab, new Vector3(-46.262f, 2, -39.4f), Quaternion.identity);

	}
}
}
