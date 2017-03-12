using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenCollider : MonoBehaviour {
    

    public GameObject blueSaeule;
    public Color32 color32 = new Color32(0, 255, 255, 255);
   
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "SaeuleBlau")
        {
            blueSaeule = GameObject.FindWithTag("SaeuleBlau");
            blueSaeule.GetComponent<Renderer>().material.color = color32;


        }
    }
}
