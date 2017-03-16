using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScriptYellow : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        transform.parent.GetComponent<ParentScriptYellow>().CollisionDetected(this);
    }

}
