using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScriptPink2 : MonoBehaviour {
    public GameObject prefab;

    public void CollisionDetected(ChildScriptPink2 childScriptPink2)
    {
        Debug.Log("child collided");
        Instantiate(prefab, new Vector3(-92.71f, 2, -22.05f), Quaternion.identity);
    }

}
