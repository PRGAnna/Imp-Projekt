using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfPlatform : MonoBehaviour {

    public GameObject blueArea;
    public Color32 color = new Color32(0, 255, 255, 255);

    void OnTriggerEnter(Collider col)
    {     
        blueArea = GameObject.FindWithTag("AreaBlue");
        blueArea.GetComponent<Renderer>().material.color = color;
    }
}
