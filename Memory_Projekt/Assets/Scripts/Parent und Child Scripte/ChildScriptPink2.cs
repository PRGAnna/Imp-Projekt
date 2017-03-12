using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScriptPink2 : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        transform.parent.GetComponent<ParentScriptPink2>().CollisionDetected(this);
    }

}