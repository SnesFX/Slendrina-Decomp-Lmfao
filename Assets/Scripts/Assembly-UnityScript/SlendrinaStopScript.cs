using System;
using UnityEngine;

[Serializable]
public class SlendrinaStopScript : MonoBehaviour
{
	public GameObject slendrinaActive;

	public NPCMovement slendrinaScript;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			slendrinaActive.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
