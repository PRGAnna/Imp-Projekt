using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfPlatformYellow : MonoBehaviour {

    public GameObject yellowArea;
    public Color32 color32 = new Color32(255, 255, 7, 255);

    void OnTriggerEnter(Collider col)
    {
        yellowArea = GameObject.FindWithTag("AreaYellow");
        yellowArea.GetComponent<Renderer>().material.color = color32;
    }
}
