using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeRedCollider : MonoBehaviour {

    public GameObject prefab;
	public Color32 color = new Color (244, 18, 18, 255);

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "triggerRed")
        {
            Instantiate(prefab, new Vector3(-64.1f, 0, 7.7f), Quaternion.identity);
			prefab.GetComponent<Renderer>().material.color = color;
        }
    }
}
