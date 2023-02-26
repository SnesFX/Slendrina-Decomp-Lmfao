using System;
using UnityEngine;

[Serializable]
public class TriggerDestroyer : MonoBehaviour
{
	public GameObject trigger;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			UnityEngine.Object.Destroy(trigger);
		}
	}

	public virtual void Main()
	{
	}
}
