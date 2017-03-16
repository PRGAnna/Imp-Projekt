using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScriptGreen : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        transform.parent.GetComponent<ParentScriptGreen>().CollisionDetected(this);
    }

}