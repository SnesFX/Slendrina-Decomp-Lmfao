using System;
using UnityEngine;

[Serializable]
public class SafeFallScript : MonoBehaviour
{
	public NPCMovement slendrinaScript;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "slendrina")
		{
			slendrinaScript.Teleportaway();
		}
	}

	public virtual void Main()
	{
	}
}
