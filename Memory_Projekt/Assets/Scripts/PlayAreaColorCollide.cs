using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAreaColorCollide : MonoBehaviour {

    

    void OnCollisionEnter(Collision col)
    {
        Renderer rend = GetComponent<Renderer>();

        if (col.gameObject.name == "PlayAreaBlue")
        {
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.blue);
        }
    }
}
