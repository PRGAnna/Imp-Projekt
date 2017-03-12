using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScript : MonoBehaviour {

    public GameObject prefab;

    public void CollisionDetected(ChildScript childScript)
    {
        Debug.Log("child collided");
        Instantiate(prefab, new Vector3(-0.38f, 2, 0.274f), Quaternion.identity);
    }

}