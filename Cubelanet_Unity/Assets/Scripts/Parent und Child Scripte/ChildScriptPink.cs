using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScriptPink : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        transform.parent.GetComponent<ParentScriptPink>().CollisionDetected(this);
    }

}