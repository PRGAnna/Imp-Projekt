using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfPlatformPink2 : MonoBehaviour {

    public GameObject pinkArea2;
    public Color32 color32 = new Color32(236, 99, 204, 255);

    void OnTriggerEnter(Collider col)
    {
        pinkArea2 = GameObject.FindWithTag("AreaPink2");
        pinkArea2.GetComponent<Renderer>().material.color = color32;
    }
}
