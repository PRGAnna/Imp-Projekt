namespace VRTK.Examples.Archery
{

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSpawner : MonoBehaviour {

	public GameObject cubePrefab;
	public Color color = Color.blue;
	public float spawnDelay = 1f;

	private float spawnDelayTimer = 0f;


	private void Start()
	{
		spawnDelayTimer = 0f;
	}

	private void OnTriggerStay(Collider collider)
	{
		VRTK_InteractGrab grabbingController = (collider.gameObject.GetComponent<VRTK_InteractGrab>() ? collider.gameObject.GetComponent<VRTK_InteractGrab>() : collider.gameObject.GetComponentInParent<VRTK_InteractGrab>());
		if (CanGrab(grabbingController) && Time.time >= spawnDelayTimer)
		{
			GameObject newArrow = Instantiate(cubePrefab);
			newArrow.name = "CubeClone";
			grabbingController.GetComponent<VRTK_InteractTouch>().ForceTouch(newArrow);
			grabbingController.AttemptGrab();
			newArrow.GetComponent<MeshRenderer>().material.color = color;
			spawnDelayTimer = Time.time + spawnDelay;
		}
	}

	private bool CanGrab(VRTK_InteractGrab grabbingController)
	{
		return (grabbingController && grabbingController.GetGrabbedObject() == null && grabbingController.gameObject.GetComponent<VRTK_ControllerEvents>().grabPressed);
	}

}
}
