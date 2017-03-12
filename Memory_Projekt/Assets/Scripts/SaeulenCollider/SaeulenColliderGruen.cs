using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderGruen : MonoBehaviour {


    public GameObject greenSaeule;
    public Color32 color32 = new Color32(0, 255, 70, 255);

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "SaeuleGruen")
        {
            greenSaeule = GameObject.FindWithTag("SaeuleGruen");
            greenSaeule.GetComponent<Renderer>().material.color = color32;


        }
    }
}
