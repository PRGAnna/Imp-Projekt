using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScript : MonoBehaviour {

    public GameObject prefab;

    public void CollisionDetected(ChildScript childScript)
    {
        Debug.Log("child collided");
        Instantiate(prefab, new Vector3(-4.3231f, 2, -1.574f), Quaternion.identity);
    }

}