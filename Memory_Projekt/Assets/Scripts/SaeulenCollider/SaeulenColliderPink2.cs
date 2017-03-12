using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaeulenColliderPink2 : MonoBehaviour {

    public GameObject pinkSaeule2;
    public Color32 color32 = new Color32(236, 99, 204, 255);

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "SaeulePink2")
        {
            pinkSaeule2 = GameObject.FindWithTag("SaeulePink2");
            pinkSaeule2.GetComponent<Renderer>().material.color = color32;


        }

    }
}