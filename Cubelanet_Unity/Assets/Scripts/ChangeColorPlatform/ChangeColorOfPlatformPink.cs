using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfPlatformPink : MonoBehaviour {

    public GameObject pinkArea;
    public Color32 color32 = new Color32(236, 99, 204, 255);

    void OnTriggerEnter(Collider col)
    {
       pinkArea = GameObject.FindWithTag("AreaPink");
       pinkArea.GetComponent<Renderer>().material.color = color32;
    }
}