using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAreaColorCollide : MonoBehaviour {

    //Renderer rend;

    //void Start()
    //{
    //   rend = GetComponent<Renderer>();
    //    rend.enabled = true;


    //}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PlayAreaBlue")
        {
            //rend.material.shader = Shader.Find("Specular");
            //rend.material.SetColor("_SpecColor", Color.blue);
            Destroy(col.gameObject);
        }
    }
}
