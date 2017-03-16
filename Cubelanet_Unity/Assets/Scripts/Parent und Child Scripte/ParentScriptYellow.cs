using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScriptYellow : MonoBehaviour {

    public GameObject prefab;

    public void CollisionDetected(ChildScriptYellow childScriptYellow)
    {
        Debug.Log("child collided");
        Instantiate(prefab, new Vector3(-59.31f, 2, -22.5f), Quaternion.identity);
    }

}
