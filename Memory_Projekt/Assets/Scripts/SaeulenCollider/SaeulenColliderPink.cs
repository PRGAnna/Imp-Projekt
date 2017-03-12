using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderPink : MonoBehaviour {

    public GameObject pinkSaeule;
    public Color32 color32 = new Color32(236, 99, 204, 255);

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "SaeulePink")
        {
           pinkSaeule = GameObject.FindWithTag("SaeulePink");
           pinkSaeule.GetComponent<Renderer>().material.color = color32;


        }
        
    }
}