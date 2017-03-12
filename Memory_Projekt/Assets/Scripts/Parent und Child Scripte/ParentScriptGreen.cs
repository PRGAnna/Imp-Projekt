using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScriptGreen : MonoBehaviour {

    public GameObject prefab;

    public void CollisionDetected(ChildScriptGreen childScriptGreen)
    {
        Debug.Log("child collided");
        Instantiate(prefab, new Vector3(-107.88f, 2, -22.5f), Quaternion.identity);
    }

}
