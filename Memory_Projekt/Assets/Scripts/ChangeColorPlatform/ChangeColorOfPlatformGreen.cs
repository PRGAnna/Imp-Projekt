using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfPlatformGreen : MonoBehaviour {

    public GameObject greenArea;
    public Color32 color32 = new Color32(0, 255, 70, 255);

    void OnTriggerEnter(Collider col)
    {
        greenArea = GameObject.FindWithTag("AreaGreen");
        greenArea.GetComponent<Renderer>().material.color = color32;
    }
}

