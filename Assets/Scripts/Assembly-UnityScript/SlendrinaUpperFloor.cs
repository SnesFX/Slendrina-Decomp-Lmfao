using System;
using UnityEngine;

[Serializable]
public class SlendrinaUpperFloor : MonoBehaviour
{
	public NPCMovement slendrinaScript;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			slendrinaScript.teleportPositionY = 2f;
		}
	}

	public virtual void Main()
	{
	}
}
