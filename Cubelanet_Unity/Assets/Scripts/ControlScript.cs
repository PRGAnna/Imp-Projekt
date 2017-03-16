using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {

	public GameObject leftControllerTooltip;
	public GameObject rightControllerTooltip;

	public void Control(){
		leftControllerTooltip.SetActive(true);
		rightControllerTooltip.SetActive(true);
	}

	public void start(){
		leftControllerTooltip.SetActive(false);
		rightControllerTooltip.SetActive(false);
	}
}
