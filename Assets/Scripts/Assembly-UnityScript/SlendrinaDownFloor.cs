using System;
using UnityEngine;

[Serializable]
public class SlendrinaDownFloor : MonoBehaviour
{
	public NPCMovement slendrinaScript;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			slendrinaScript.teleportPositionY = -1f;
		}
	}

	public virtual void Main()
	{
	}
}
