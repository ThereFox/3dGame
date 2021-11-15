using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchingButton : MonoBehaviour
{
    public GameObject[] groupOne;
	public GameObject[] groupTwo;
	public Material active;
	public Material disabled;
    
	private void  OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("interactiveObject") || other.CompareTag("Player")){
			switching(groupOne, true);
			switching(groupTwo, false);
			GetComponent<Renderer>().material = disabled;
		}
	}

	private void  OnTriggerExit(Collider other)
	{
		if(other.CompareTag("interactiveObject") || other.CompareTag("Player")){
			switching(groupOne, false);
			switching(groupTwo, true);
			GetComponent<Renderer>().material = active;
		}
	}
	
	private void switching (GameObject[] group, bool isTriggered)
	{
		foreach(GameObject element in group)
			{
				element.GetComponent<Renderer>().material = (isTriggered ? active : disabled);
				element.GetComponent<Collider>().isTrigger = !isTriggered;
			}
	}

}
