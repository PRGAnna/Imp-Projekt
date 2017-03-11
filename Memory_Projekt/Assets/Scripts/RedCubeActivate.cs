using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeActivate : MonoBehaviour {

    //public GameObject prefab;
    public GameObject blueSaeule;
    public Renderer renderer;
    public Color32 color32 = new Color32(0, 255, 255, 255);
 
    public void redCube () {
       
       blueSaeule = GameObject.FindWithTag("SaeuleBlau");

        if (blueSaeule.GetComponent<Renderer>().sharedMaterial.Equals(color32))
        {
            Debug.Log("huh");
        }
        
    }
}