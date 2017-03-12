using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderGelb : MonoBehaviour {

    public GameObject yellowSaeule;
    public Color32 color32 = new Color32(0, 255, 255, 7);

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "SaeuleGelb")
        {
            yellowSaeule = GameObject.FindWithTag("SaeuleGelb");
            yellowSaeule.GetComponent<Renderer>().material.color = color32;


        }
    }
}

