﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScriptPink : MonoBehaviour {

    public GameObject prefab;

    public void CollisionDetected(ChildScriptPink childScriptPink)
    {
        Debug.Log("child collided");
        Instantiate(prefab, new Vector3(-76.44f, 2, -22.5f), Quaternion.identity);
    }

}
